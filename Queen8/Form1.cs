using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queen8
{
    public partial class Queen8 : Form
    {
        public Queen8()
        {
            InitializeComponent();
        }
        PictureBox[,] Сells = new PictureBox[8, 8]; //клетки
        int numQeens = 0; //кол ферзей
        int[] stolb = new int[8]; //для проверки столбцов
        int[] strok = new int[8]; //для проверки строк
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Сells[i, j] = new PictureBox(); //заполнение
                    Сells[i, j].Size = new Size(40, 40);
                    Сells[i, j].Location = new Point(i * 40, j * 40);
                    Сells[i, j].Tag = new Point(i, j);
                    if ((i + j) % 2 == 0) Сells[i, j].BackColor = SystemColors.Info; //белый цвет если четные
                    else Сells[i, j].BackColor = Color.Chocolate; //черный цвет если не четные
                    Сells[i, j].Image = Properties.Resources.ферзь; //изо в пикчебокс
                    this.Controls.Add(Сells[i, j]);
                    this.Сells[i, j].Click += new EventHandler(this.Сells_Click);
                    Сells[i, j].Enabled = false;
                }
                stolb[i] = -1; //очистка массива для того что-бы можно было ставить на 0
                strok[i] = -1;
            }
        }
        bool ft = true; //кнопка ручной расстановки
        private void button1_Click(object sender, EventArgs e)
        {
            if (ft)
            {
                Сleaning(true);
                Start.Text = "Завершить";
                cellCheckTxt.Text = "_ | _";
                Start.ForeColor = Color.Red;
            }
            else
            {
                Сleaning(true);
                Start.Text = "Начать";
                Start.ForeColor = Color.Lime;
            }
            ft = !ft;
        }
        int constX, constY, constNumQeens; //переменные для 1 ферзя
        bool oneClick = true;
        private void Сells_Click(object sender, EventArgs e)
        {
            PictureBox cell = (PictureBox)sender;
            if (oneClick && checkBoxAuto.Checked == true)// ставим только 1 ферзя
            {
                cellCheckTxt.Text = "_ | _";
                Point index = (Point)cell.Tag;
                constX = index.X; //столбец
                constY = index.Y; //строка
                Сells[constX, constY].SizeMode = PictureBoxSizeMode.StretchImage;
                Сells[constX, constY].Enabled = false;
                numQeens++;
                constNumQeens = numQeens;
                stolb[numQeens] = constX; //запоминаем позицию
                strok[numQeens] = constY;
                numQueenTxt.Text = $"{numQeens + 1} ферзь";
                oneClick = false; //больше не даём нажать
                autoPlacementOneMove(); //запускаем основной метод с 1 кликом
            }
            if (checkBoxAuto.Checked == false && Start.Text == "Завершить") //ручная расстановка
            {
                Point index = (Point)cell.Tag;
                int x = index.X; //столбец
                int y = index.Y; //строка
                examination(x, y);
            }

        }
        bool globalZanito; //проверка занят ли целый столбец
        void examination(int x, int y)
        {
            bool zanito = true; //общая проверка занято ли
            globalZanito = true;
            for (int i = 0; i < 8; i++) //проверка на занятость столбиков и столбцов
            {
                if (stolb[i] == x || strok[i] == y)
                {
                    zanito = false;
                    if (stolb[i] == x)//проверка занят ли целый столбец
                    {
                        globalZanito = false;
                    }
                    break;
                }
            }
            if (zanito && Сells[x, y].Enabled /*!= false*/) //проверки на другие направления (наискосок)
            {
                for (int i = y, j = x; i >= 0; i--) //в правый верхний угол
                {
                    if (j > 7) break;
                    if (Сells[j, i].Enabled == false)
                    {
                        zanito = false;
                        break;
                    }
                    j++;
                }
                if (zanito)
                {
                    for (int i = y, j = x; i >= 0; i--) //в левый верхний угол
                    {
                        if (j < 0) break;
                        if (Сells[j, i].Enabled == false)
                        {
                            zanito = false;
                            break;
                        }
                        j--;
                    }
                }
                if (zanito)
                {
                    for (int i = y, j = x; i <= 7; i++) //в правый нижний угол
                    {
                        if (j > 7) break;
                        if (Сells[j, i].Enabled == false)
                        {
                            zanito = false;
                            break;
                        }
                        j++;
                    }
                }
                if (zanito)
                {
                    for (int i = y, j = x; i <= 7; i++) //в левый нижний угол
                    {
                        if (j < 0) break;
                        if (Сells[j, i].Enabled == false)
                        {
                            zanito = false;
                            break;
                        }
                        j--;
                    }
                }
                //финальная проверка
                if (zanito)
                {
                    Сells[x, y].SizeMode = PictureBoxSizeMode.StretchImage; //если по итогу не занята, то отображаем картинку
                    Сells[x, y].Enabled = false; //для фиксации занято или нет
                    numQeens++; //увеличение счетчика количества ферзей

                    if (numQeens < 8) //проверка есть ли все ферзи
                    {
                        stolb[numQeens] = x; //если не все, то запоминаем позицию и увеличиваем текст
                        strok[numQeens] = y;
                        numQueenTxt.Text = $"{numQeens + 1} ферзь";
                    }
                    else
                    {
                        numQueenTxt.Text = $"Удачно!"; //если удачно, то говорим об этом
                        cellCheck(); //и выводим проверку сколько по итогу ферзей
                    }
                }
            }

        }
        Random rnd = new Random();
        void autoPlacementOneMove() //метод авто расстановки ферзей при первом уже расставленном
        {
            cellCheckTxt.Text = "_ | _";
            int rndX, rndY;
            numQeens = 1; //1 т.к первый уже расставлен
            do //рандомно расставляем 5 ферзей пока все не расставятся
            {
                for (int i = 0; i < 5; i++)
                {
                    rndX = rnd.Next(0, 8);
                    rndY = rnd.Next(0, 8);
                    if (rndX != constX || rndY != constY) // сразу проверяем можно ли поставить по 1 ферзю
                    {
                        examination(rndX, rndY);
                    }
                    if (numQeens == 5) // сразу проверяем расставлены ли все для ускорения работы
                    {
                        break;
                    }
                }
            } while (numQeens < 5);
            for (int i = 0; i < 8; i++) //пытаемся расставить остальные на оставшиеся клетки
            {
                for (int j = 0; j < 8; j++)
                {
                    examination(i, j);
                    if (globalZanito == false || numQeens == 8) // сразу проверяем расставлены ли все или занят ли столбец для ускорения работы
                    {
                        break;
                    }
                }
                if (numQeens == 8) // сразу проверяем расставлены ли все для ускорения работы
                {
                    break;
                }
            }
            if (numQeens < 8)//если по итогу не все расставлены то повторяем операцию
            {
                Сleaning(); // нету true т.к мы не удаляем нашего 1-ого ферзя
                autoPlacementOneMove();
            }
        }

        void autoPlacement()//метод полной авто расстановки ферзей
        {
            cellCheckTxt.Text = "_ | _";
            int rndX, rndY;
            do
            {
                for (int i = 0; i < 5; i++)
                {
                    rndX = rnd.Next(0, 8);
                    rndY = rnd.Next(0, 8);
                    examination(rndX, rndY);
                    if (numQeens == 5)// сразу проверяем расставлены ли все для ускорения работы
                    {
                        break;
                    }
                }
            } while (numQeens < 5);
            for (int i = 0; i < 8; i++)//пытаемся расставить остальные на оставшиеся клетки
            {
                for (int j = 0; j < 8; j++)
                {
                    examination(i, j);
                    if (globalZanito == false || numQeens == 8)// сразу проверяем расставлены ли все или занят ли столбец для ускорения работы
                    {
                        break;
                    }
                }
                if (numQeens == 8)// сразу проверяем расставлены ли все для ускорения работы
                {
                    break;
                }
            }
            if (numQeens < 8)//если по итогу не все расставлены то повторяем операцию
            {
                Сleaning(true);// есть true т.к мы удаляем всех ферзей
                autoPlacement();
            }
        }
        private void button2_Click(object sender, EventArgs e) //кнопка полной авто расстановки ферзей
        {
            Сleaning(true);
            autoPlacement();
        }
        private void button3_Click(object sender, EventArgs e)//кнопка полной очистки
        {
            Сleaning(true);
            oneClick = true;
        }
        void cellCheck()// проверка сколько по итогу ферзей
        {
            int cout = 0, cout2 = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Сells[i, j].SizeMode != PictureBoxSizeMode.Normal) cout++;
                    if (Сells[i, j].Enabled != true) cout2++;
                }
            }
            cellCheckTxt.Text = cout.ToString() + " | " + cout2.ToString();
        }
        void Сleaning(bool ft = false)//очистка 
        {
            numQueenTxt.Text = $"В процессе...";
            cellCheckTxt.Text = "_ | _";
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Сells[i, j] != Сells[constX, constY] || ft) //для проверки очистки 1-ого ферзя 
                    {
                        Сells[i, j].Enabled = true; //за занятость отвечает это и мы чистим
                        Сells[i, j].SizeMode = PictureBoxSizeMode.Normal; //точнее не очистки а увеличению размера
                    }
                }
                if (i != constNumQeens || ft) //так-же чистим доп массивы и проверяем на 1-ого ферзя
                {
                    stolb[i] = -1;
                    strok[i] = -1;
                }
            }
            numQeens = 0; //обнуляем счетчик

            if (ft) numQueenTxt.Text = $"Выберите\nклетку";
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)//чекбокс для авто или обычной расстановки 
        {
            if (checkBoxAuto.Checked) //делаем активными или не активными кнопки и запускаем очистку для предотвращения ошибок
            {
                oneClick = true;
                cleaning.Enabled = true;
                Auto.Enabled = false;
                Start.Enabled = false;
                Сleaning(true);
            }
            else
            {
                oneClick = false;
                Сleaning(true);
                cleaning.Enabled = false;
                Start.Enabled = true;
                Auto.Enabled = true;
            }
        }
    }
}
