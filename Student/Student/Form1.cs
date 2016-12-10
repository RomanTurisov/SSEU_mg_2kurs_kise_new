using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class FormStudent : Form
    {
        Student student1 = new Student();   //объект класса Студент
        public FormStudent()
        {
            InitializeComponent();
        }

        private void textBoxFIO_TextChanged(object sender, EventArgs e)
        {
            student1.FIO = textBoxFIO.Text; //сохранить ФИО
            textBoxStudentInfo.Text = student1.ToString();  //вывести на экран
        }
        private void textBoxNstud_TextChanged(object sender, EventArgs e)
        {
            student1.Nstud = textBoxNstud.Text;   //сохранить № студбилета
            textBoxStudentInfo.Text = student1.ToString();  //вывести на экран
        }
        private void numericUpDownKurs_ValueChanged(object sender, EventArgs e)
        {
            student1.kurs = (int)numericUpDownKurs.Value;   //сохранить курс
            //вывод списка семестров
            comboBoxSemestr.Items.Clear(); //очистка списка
            //перебираем курсы с 1 до того, на котором учится студент
            for (int k = 1; k <= student1.kurs; k++)
            {
                int s1 = 2 * k - 1; //номер осеннего семестра на курсе k
                int s2 = 2 * k; //номер весеннего семестра на курсе k
                //добавляем в список
                comboBoxSemestr.Items.Add(s1 + " семестр");
                comboBoxSemestr.Items.Add(s2 + " семестр");
            };
            //выбираем выделенный семестр - первый (отчет с 0)
            comboBoxSemestr.SelectedIndex = 0;
            textBoxStudentInfo.Text = student1.ToString();  //вывести на экран
        }

        private void radioButtonBudget_CheckedChanged(object sender, EventArgs e)
        {
            //если выбрано обучение на бюджете
            if (radioButtonBudget.Checked)
            {
                //то создать бюджетника
                student1 = new StudentBudg(student1);
                //скрыть элементы для платников
                labelStoimost.Visible = false;
                numericUpDownStoimost.Visible = false;
                numericUpDownSum.Visible = false;
                buttonOplatit.Visible = false;
            }
            //иначе - обучение на коммерческой основе
            else
            {
                //создать платника
                student1 = new StudentPlat(student1);
                //отобразить элементы для платников
                labelStoimost.Visible = true;
                numericUpDownStoimost.Visible = true;
                numericUpDownSum.Visible = true;
                buttonOplatit.Visible = true;
            }
            textBoxStudentInfo.Text = student1.ToString();  //вывести на экран
        }
        private void textBoxGruppa_TextChanged(object sender, EventArgs e)
        {
            student1.gruppa = textBoxGruppa.Text; //сохранить группу
            textBoxStudentInfo.Text = student1.ToString();  //вывести на экран
        }
        //содержимое полей в виде текста
        private void numericUpDownEkz1_ValueChanged(object sender, EventArgs e)
        {
            //записать оценку в массив, првиедя к типу byte
            student1.ozenki[comboBoxSemestr.SelectedIndex, 0] = (byte)numericUpDownEkz1.Value;
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void numericUpDownEkz2_ValueChanged(object sender, EventArgs e)
        {
            //записать оценку в массив, првиедя к типу byte
            student1.ozenki[comboBoxSemestr.SelectedIndex, 1] = (byte)numericUpDownEkz2.Value;
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void numericUpDownEkz3_ValueChanged(object sender, EventArgs e)
        {
            //записать оценку в массив, првиедя к типу byte
            student1.ozenki[comboBoxSemestr.SelectedIndex, 2] = (byte)numericUpDownEkz3.Value;
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void numericUpDownEkz4_ValueChanged(object sender, EventArgs e)
        {
            //записать оценку в массив, првиедя к типу byte
            student1.ozenki[comboBoxSemestr.SelectedIndex, 3] = (byte)numericUpDownEkz4.Value;
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void numericUpDownEkz5_ValueChanged(object sender, EventArgs e)
        {
            //записать оценку в массив, првиедя к типу byte
            student1.ozenki[comboBoxSemestr.SelectedIndex, 4] = (byte)numericUpDownEkz5.Value;
            textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
        }

        private void comboBoxSemestr_SelectedIndexChanged(object sender, EventArgs e)
        {
            //вывести оценки за выбранный семестр
            //если не было экзамена
            if (student1.ozenki[comboBoxSemestr.SelectedIndex, 0] == 0)
            {
                checkBoxEkz1.Checked = false; //снять флажок
            }
            else //иначе экзамен был
            {
                checkBoxEkz1.Checked = true; //установить флажок
                //если неявка
                if (student1.ozenki[comboBoxSemestr.SelectedIndex, 0] == 1)
                {
                    checkBoxEkz1neyavka.Checked = true; //утсановить флажок
                }
                else
                {
                    checkBoxEkz1neyavka.Checked = false; //снять флажок
                    //вывести оценку
                    numericUpDownEkz1.Value = student1.ozenki[comboBoxSemestr.SelectedIndex, 0];
                };
            };
            //вывести оценки за выбранный семестр
            //если не было экзамена
            if (student1.ozenki[comboBoxSemestr.SelectedIndex, 1] == 0)
            {
                checkBoxEkz2.Checked = false; //снять флажок
            }
            else //иначе экзамен был
            {
                checkBoxEkz2.Checked = true; //установить флажок
                //если неявка
                if (student1.ozenki[comboBoxSemestr.SelectedIndex, 1] == 1)
                {
                    checkBoxEkz2neyavka.Checked = true; //утсановить флажок
                }
                else
                {
                    checkBoxEkz2neyavka.Checked = false; //снять флажок
                    //вывести оценку
                    numericUpDownEkz2.Value = student1.ozenki[comboBoxSemestr.SelectedIndex, 1];
                };
            };
            //вывести оценки за выбранный семестр
            //если не было экзамена
            if (student1.ozenki[comboBoxSemestr.SelectedIndex, 2] == 0)
            {
                checkBoxEkz3.Checked = false; //снять флажок
            }
            else //иначе экзамен был
            {
                checkBoxEkz3.Checked = true; //установить флажок
                //если неявка
                if (student1.ozenki[comboBoxSemestr.SelectedIndex, 2] == 1)
                {
                    checkBoxEkz3neyavka.Checked = true; //утсановить флажок
                }
                else
                {
                    checkBoxEkz3neyavka.Checked = false; //снять флажок
                    //вывести оценку
                    numericUpDownEkz3.Value = student1.ozenki[comboBoxSemestr.SelectedIndex, 2];
                };
            };
            //вывести оценки за выбранный семестр
            //если не было экзамена
            if (student1.ozenki[comboBoxSemestr.SelectedIndex, 3] == 0)
            {
                checkBoxEkz4.Checked = false; //снять флажок
            }
            else //иначе экзамен был
            {
                checkBoxEkz4.Checked = true; //установить флажок
                //если неявка
                if (student1.ozenki[comboBoxSemestr.SelectedIndex, 3] == 1)
                {
                    checkBoxEkz4neyavka.Checked = true; //утсановить флажок
                }
                else
                {
                    checkBoxEkz4neyavka.Checked = false; //снять флажок
                    //вывести оценку
                    numericUpDownEkz4.Value = student1.ozenki[comboBoxSemestr.SelectedIndex, 3];
                };
            };
            //вывести оценки за выбранный семестр
            //если не было экзамена
            if (student1.ozenki[comboBoxSemestr.SelectedIndex, 4] == 0)
            {
                checkBoxEkz5.Checked = false; //снять флажок
            }
            else //иначе экзамен был
            {
                checkBoxEkz5.Checked = true; //установить флажок
                //если неявка
                if (student1.ozenki[comboBoxSemestr.SelectedIndex, 4] == 1)
                {
                    checkBoxEkz5neyavka.Checked = true; //утсановить флажок
                }
                else
                {
                    checkBoxEkz5neyavka.Checked = false; //снять флажок
                    //вывести оценку
                    numericUpDownEkz5.Value = student1.ozenki[comboBoxSemestr.SelectedIndex, 4];
                };
            };
        }

        private void checkBoxEkz1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz1.Checked) //если экзамен был
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz1.Minimum = 2;
                numericUpDownEkz1.Value = 4;
                //оценку можно вводить
                numericUpDownEkz1.Enabled = true;
                //можно поставить неявку
                checkBoxEkz1neyavka.Enabled = true;
            }
            else //иначе - эсзамена не было
            {
                //оценка 0, нужно изменить нижнюю границу
                numericUpDownEkz1.Minimum = 0;
                numericUpDownEkz1.Value = 0;
                //оценку нельзя вводить
                numericUpDownEkz1.Enabled = false;
                //неявку нельзя поставить
                checkBoxEkz1neyavka.Enabled = false;
            };
        }

        private void checkBoxEkz1neyavka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz1neyavka.Checked) //если неявка
            {
                //оценка 1, нужно изменить нижнюю границу
                numericUpDownEkz1.Minimum = 1;
                numericUpDownEkz1.Value = 1;
                //вводить оценку нельзя
                numericUpDownEkz1.Enabled = false;
            }
            else //иначе - студент явился
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz1.Minimum = 2;
                numericUpDownEkz1.Value = 4;
                //оценку можно вводить
                numericUpDownEkz1.Enabled = true;
            };
        }

        private void checkBoxEkz2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz2.Checked) //если экзамен был
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz2.Minimum = 2;
                numericUpDownEkz2.Value = 4;
                //оценку можно вводить
                numericUpDownEkz2.Enabled = true;
                //можно поставить неявку
                checkBoxEkz2neyavka.Enabled = true;
            }
            else //иначе - эсзамена не было
            {
                //оценка 0, нужно изменить нижнюю границу
                numericUpDownEkz2.Minimum = 0;
                numericUpDownEkz2.Value = 0;
                //оценку нельзя вводить
                numericUpDownEkz2.Enabled = false;
                //неявку нельзя поставить
                checkBoxEkz2neyavka.Enabled = false;
            };
        }

        private void checkBoxEkz2neyavka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz2neyavka.Checked) //если неявка
            {
                //оценка 1, нужно изменить нижнюю границу
                numericUpDownEkz2.Minimum = 1;
                numericUpDownEkz2.Value = 1;
                //вводить оценку нельзя
                numericUpDownEkz2.Enabled = false;
            }
            else //иначе - студент явился
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz2.Minimum = 2;
                numericUpDownEkz2.Value = 4;
                //оценку можно вводить
                numericUpDownEkz2.Enabled = true;
            };
        }

        private void checkBoxEkz3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz1.Checked) //если экзамен был
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz3.Minimum = 2;
                numericUpDownEkz3.Value = 4;
                //оценку можно вводить
                numericUpDownEkz3.Enabled = true;
                //можно поставить неявку
                checkBoxEkz3neyavka.Enabled = true;
            }
            else //иначе - эсзамена не было
            {
                //оценка 0, нужно изменить нижнюю границу
                numericUpDownEkz3.Minimum = 0;
                numericUpDownEkz3.Value = 0;
                //оценку нельзя вводить
                numericUpDownEkz3.Enabled = false;
                //неявку нельзя поставить
                checkBoxEkz3neyavka.Enabled = false;
            };
        }

        private void checkBoxEkz3neyavka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz3neyavka.Checked) //если неявка
            {
                //оценка 1, нужно изменить нижнюю границу
                numericUpDownEkz3.Minimum = 1;
                numericUpDownEkz3.Value = 1;
                //вводить оценку нельзя
                numericUpDownEkz3.Enabled = false;
            }
            else //иначе - студент явился
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz3.Minimum = 2;
                numericUpDownEkz3.Value = 4;
                //оценку можно вводить
                numericUpDownEkz3.Enabled = true;
            };
        }

        private void checkBoxEkz4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz1.Checked) //если экзамен был
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz4.Minimum = 2;
                numericUpDownEkz4.Value = 4;
                //оценку можно вводить
                numericUpDownEkz4.Enabled = true;
                //можно поставить неявку
                checkBoxEkz4neyavka.Enabled = true;
            }
            else //иначе - эсзамена не было
            {
                //оценка 0, нужно изменить нижнюю границу
                numericUpDownEkz4.Minimum = 0;
                numericUpDownEkz4.Value = 0;
                //оценку нельзя вводить
                numericUpDownEkz4.Enabled = false;
                //неявку нельзя поставить
                checkBoxEkz4neyavka.Enabled = false;
            };
        }

        private void checkBoxEkz4neyavka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz4neyavka.Checked) //если неявка
            {
                //оценка 1, нужно изменить нижнюю границу
                numericUpDownEkz4.Minimum = 1;
                numericUpDownEkz4.Value = 1;
                //вводить оценку нельзя
                numericUpDownEkz4.Enabled = false;
            }
            else //иначе - студент явился
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz4.Minimum = 2;
                numericUpDownEkz4.Value = 4;
                //оценку можно вводить
                numericUpDownEkz4.Enabled = true;
            };
        }

        private void checkBoxEkz5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz1.Checked) //если экзамен был
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz5.Minimum = 2;
                numericUpDownEkz5.Value = 4;
                //оценку можно вводить
                numericUpDownEkz5.Enabled = true;
                //можно поставить неявку
                checkBoxEkz5neyavka.Enabled = true;
            }
            else //иначе - эсзамена не было
            {
                //оценка 0, нужно изменить нижнюю границу
                numericUpDownEkz5.Minimum = 0;
                numericUpDownEkz5.Value = 0;
                //оценку нельзя вводить
                numericUpDownEkz5.Enabled = false;
                //неявку нельзя поставить
                checkBoxEkz5neyavka.Enabled = false;
            };
        }

        private void checkBoxEkz5neyavka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz5neyavka.Checked) //если неявка
            {
                //оценка 1, нужно изменить нижнюю границу
                numericUpDownEkz5.Minimum = 1;
                numericUpDownEkz5.Value = 1;
                //вводить оценку нельзя
                numericUpDownEkz5.Enabled = false;
            }
            else //иначе - студент явился
            {
                //оценка от 2 до 5, по умолчанию 4
                numericUpDownEkz5.Minimum = 2;
                numericUpDownEkz5.Value = 4;
                //оценку можно вводить
                numericUpDownEkz5.Enabled = true;
            };
        }

        private void buttonNaSledKurs_Click(object sender, EventArgs e)
        {
            //выполнить перевод
            student1.PerevestiNaSledKurs();
            //вывести на форму
            numericUpDownKurs.Value = student1.kurs;
            textBoxStudentInfo.Text = student1.ToString();
        }

        private void numericUpDownStoimost_ValueChanged(object sender, EventArgs e)
        {
            //проверка - если студент - платник
            if (student1 is StudentPlat)
            {
                //то установить стоимость обучения
                (student1 as StudentPlat).stoimostObucheniya = numericUpDownStoimost.Value;
                textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
            }
        }

        private void buttonOplatit_Click(object sender, EventArgs e)
        {
            //проверка - если студент - платник
            if (student1 is StudentPlat)
            {
                //то оплатить указанную сумму
                (student1 as StudentPlat).OplataObuchenie(numericUpDownSum.Value);
                textBoxStudentInfo.Text = student1.ToString(); //вывести на экран
            }
        }
    }
}