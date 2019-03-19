using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_OOTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxProfession.SelectedIndex = 0;
        }
        List<RestaurantWorker> Workers = new List<RestaurantWorker>();

        //Обновление dataGridView
        private void dataGridAndAllListsUpdate()
        {
            listBoxInfo.Items.Clear();
            listBoxInfo.Items.Add("Выберите работника.");
            dataGridView1.Rows.Clear();
            ClearTextBoxes();
            for (int i = 0; i < Workers.Count; i++)
                dataGridView1.Rows.Add(Workers[i].Name, Workers[i].Surname, Workers[i].DateOfBirth, $"{Workers[i].Address.City} ул.{Workers[i].Address.Street}, д.{Workers[i].Address.Building} кв.{Workers[i].Address.Flat}");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите удалить работника " + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value + "?", "Удаление работника", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Workers.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
                    MessageBox.Show("Работник успешно удалён!");
                }
                else
                    MessageBox.Show("Работник не удалён!");
                dataGridAndAllListsUpdate();
            }
            catch
            {
                MessageBox.Show("Выберите работника!");
            }
        }

        private void ClearTextBoxes()
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxSalary.Clear();
            textBoxPhone.Clear();
            dateTimePicker1.Value = DateTime.Today;
            textBoxCity.Clear();
            textBoxStreet.Clear();
            textBoxBuilding.Clear();
            textBoxFlat.Clear();
            textBox1.Clear();
            textBoxSecond.Clear();
            comboBoxProfession.SelectedIndex = 0;
        }

        private void FillTextBoxes()
        {
            textBoxName.Text = Workers[dataGridView1.SelectedCells[0].RowIndex].Name;
            textBoxSurname.Text = Workers[dataGridView1.SelectedCells[0].RowIndex].Surname;
            textBoxSalary.Text = Workers[dataGridView1.SelectedCells[0].RowIndex].Salary.ToString();
            textBoxPhone.Text = Workers[dataGridView1.SelectedCells[0].RowIndex].Phone;
            dateTimePicker1.Value = Workers[dataGridView1.SelectedCells[0].RowIndex].DateOfBirth;
            textBoxCity.Text = Workers[dataGridView1.SelectedCells[0].RowIndex].Address.City;
            textBoxStreet.Text = Workers[dataGridView1.SelectedCells[0].RowIndex].Address.Street;
            textBoxBuilding.Text = Workers[dataGridView1.SelectedCells[0].RowIndex].Address.Building.ToString();
            textBoxFlat.Text = Workers[dataGridView1.SelectedCells[0].RowIndex].Address.Flat.ToString();

            comboBoxProfession.SelectedIndex = 0;
            if (Workers[dataGridView1.SelectedCells[0].RowIndex] is Waiter)
            {
                comboBoxProfession.SelectedIndex = 1;
                Waiter curr = Workers[dataGridView1.SelectedCells[0].RowIndex] as Waiter;
                textBox1.Text = curr.Tips.ToString();
            }
            else if (Workers[dataGridView1.SelectedCells[0].RowIndex] is Manager)
            {
                comboBoxProfession.SelectedIndex = 2;
                Manager curr = Workers[dataGridView1.SelectedCells[0].RowIndex] as Manager;
                textBox1.Text = curr.Suborditates.ToString();
            }
            else if (Workers[dataGridView1.SelectedCells[0].RowIndex] is Chief)
            {
                comboBoxProfession.SelectedIndex = 4;
                Chief currChief = Workers[dataGridView1.SelectedCells[0].RowIndex] as Chief;
                textBox1.Text = currChief.Category.ToString();
                textBoxSecond.Text = currChief.SignatureDish;
                checkBoxSwear.Checked = currChief.SwearLikeGordon;
            }
            else if (Workers[dataGridView1.SelectedCells[0].RowIndex] is Cook)
            {
                comboBoxProfession.SelectedIndex = 3;
                Cook curr = Workers[dataGridView1.SelectedCells[0].RowIndex] as Cook;
                textBox1.Text = curr.Category.ToString();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputtedValues())
                {
                    Workers[dataGridView1.SelectedCells[0].RowIndex].Name = textBoxName.Text;
                    Workers[dataGridView1.SelectedCells[0].RowIndex].Surname = textBoxSurname.Text;
                    Workers[dataGridView1.SelectedCells[0].RowIndex].Salary = Convert.ToDouble(textBoxSalary.Text);
                    Workers[dataGridView1.SelectedCells[0].RowIndex].Phone = textBoxPhone.Text;
                    Workers[dataGridView1.SelectedCells[0].RowIndex].DateOfBirth = dateTimePicker1.Value;
                    Workers[dataGridView1.SelectedCells[0].RowIndex].Address.City = textBoxCity.Text;
                    Workers[dataGridView1.SelectedCells[0].RowIndex].Address.Street = textBoxStreet.Text;
                    Workers[dataGridView1.SelectedCells[0].RowIndex].Address.Building = Convert.ToInt32(textBoxBuilding.Text);
                    Workers[dataGridView1.SelectedCells[0].RowIndex].Address.Flat = Convert.ToInt32(textBoxFlat.Text);

                    comboBoxProfession.SelectedIndex = 0;
                    if (Workers[dataGridView1.SelectedCells[0].RowIndex] is Waiter)
                    {
                        comboBoxProfession.SelectedIndex = 1;
                        Waiter curr = Workers[dataGridView1.SelectedCells[0].RowIndex] as Waiter;
                        curr.Tips = Convert.ToInt32(textBox1.Text);
                        Workers[dataGridView1.SelectedCells[0].RowIndex] = curr;
                    }
                    else if (Workers[dataGridView1.SelectedCells[0].RowIndex] is Manager)
                    {
                        comboBoxProfession.SelectedIndex = 2;
                        Manager curr = Workers[dataGridView1.SelectedCells[0].RowIndex] as Manager;
                        curr.Suborditates = Convert.ToInt32(textBox1.Text);
                        Workers[dataGridView1.SelectedCells[0].RowIndex] = curr;
                    }
                    else if (Workers[dataGridView1.SelectedCells[0].RowIndex] is Chief)
                    {
                        comboBoxProfession.SelectedIndex = 4;
                        Chief currChief = Workers[dataGridView1.SelectedCells[0].RowIndex] as Chief;
                        currChief.Category = Convert.ToInt32(textBox1.Text);
                        currChief.SignatureDish = textBoxSecond.Text;
                        currChief.SwearLikeGordon = checkBoxSwear.Checked;
                        Workers[dataGridView1.SelectedCells[0].RowIndex] = currChief;
                    }
                    else if (Workers[dataGridView1.SelectedCells[0].RowIndex] is Cook)
                    {
                        comboBoxProfession.SelectedIndex = 3;
                        Cook curr = Workers[dataGridView1.SelectedCells[0].RowIndex] as Cook;
                        curr.Category = Convert.ToInt32(textBox1.Text);
                        Workers[dataGridView1.SelectedCells[0].RowIndex] = curr;
                    }
                    dataGridAndAllListsUpdate();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
            catch
            {
                MessageBox.Show("Выберите работника!");
            }
        }


        private void listBoxInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            listBoxInfo.Items.Clear();
            FillTextBoxes();
            try
            {
                listBoxInfo.Items.Add($"{ Workers[dataGridView1.SelectedCells[0].RowIndex].Name} { Workers[dataGridView1.SelectedCells[0].RowIndex].Surname}");
                listBoxInfo.Items.Add($"Телефон: { Workers[dataGridView1.SelectedCells[0].RowIndex].Phone}");
                listBoxInfo.Items.Add($"Зарплатка: { Workers[dataGridView1.SelectedCells[0].RowIndex].Salary}");

                
                if (Workers[dataGridView1.SelectedCells[0].RowIndex] is Waiter)
                {
                    Waiter curr = Workers[dataGridView1.SelectedCells[0].RowIndex] as Waiter;
                    listBoxInfo.Items.Add("Должность: официант");
                    listBoxInfo.Items.Add($"Чаевые: { curr.Tips}");
                }
                else if (Workers[dataGridView1.SelectedCells[0].RowIndex] is Manager)
                {
                    Manager curr = Workers[dataGridView1.SelectedCells[0].RowIndex] as Manager;
                    listBoxInfo.Items.Add("Должность: менеджер");
                    listBoxInfo.Items.Add($"Подчиненные: { curr.Suborditates}");
                }
                else if (Workers[dataGridView1.SelectedCells[0].RowIndex] is Chief)
                {
                    Chief currChief = Workers[dataGridView1.SelectedCells[0].RowIndex] as Chief;
                    listBoxInfo.Items.Add("Должность: шеф-повар");
                    listBoxInfo.Items.Add($"Разряд: { currChief.Category}");
                    listBoxInfo.Items.Add($"Коронное блюдо: { currChief.SignatureDish}");
                    if (currChief.SwearLikeGordon)
                        listBoxInfo.Items.Add("Матюкается как сапожник");
                    else
                        listBoxInfo.Items.Add("Девочка/мальчик-пай");
                }
                
                else if (Workers[dataGridView1.SelectedCells[0].RowIndex] is Cook)
                {
                    Cook curr = Workers[dataGridView1.SelectedCells[0].RowIndex] as Cook;
                    listBoxInfo.Items.Add("Должность: повар");
                    listBoxInfo.Items.Add($"Разряд: { curr.Category}");
                }
                else
                {
                    listBoxInfo.Items.Add("Должность: работник ресторана");
                }
            }
            catch
            {
                MessageBox.Show("Выберите работника!");
            }
        }

        private static RestaurantWorker getWorkerTypeByString(string workerChosen, string name, string surname, DateTime dateOfBirth, string phone, Address address, double salary, int firstParam, string secondParam, bool swearLikeGordon)
        {
            if (workerChosen.Equals("Официант"))
                return new Waiter(name, surname, dateOfBirth, phone, address, salary);
            else if (workerChosen.Equals("Не уточнено"))
                return new RestaurantWorker(name, surname, dateOfBirth, phone, address, salary);
            else if (workerChosen.Equals("Повар"))
                return new Cook(name, surname, dateOfBirth, phone, address, salary, firstParam);
            else if (workerChosen.Equals("Менеджер"))
                return new Manager(name, surname, dateOfBirth, phone, address, salary, firstParam);
            else if (workerChosen.Equals("Шеф-повар"))
                return new Chief(name, surname, dateOfBirth, phone, address, salary, firstParam, swearLikeGordon, secondParam);
            else
                throw new Exception(workerChosen + " не существует в списке должностей!");
        }

        private bool inputtedValues()
        {
            if (textBoxName.Text == "" || textBoxSurname.Text == "" || textBoxPhone.Text == "" || textBoxSalary.Text == "" || textBoxCity.Text == "" || textBoxStreet.Text == "" || textBoxBuilding.Text == "")
                return false;
            else
                return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (inputtedValues())
            {
                Address currAddr;
                if (textBoxFlat.Text == "")
                    currAddr = new Address(textBoxCity.Text, textBoxStreet.Text, Convert.ToInt32(textBoxBuilding.Text));
                else
                    currAddr = new Address(textBoxCity.Text, textBoxStreet.Text, Convert.ToInt32(textBoxBuilding.Text), Convert.ToInt32(textBoxFlat.Text));
                int firstParam;
                try
                {
                    firstParam = Convert.ToInt32(textBox1.Text);
                }
                catch
                {
                    firstParam = 0;
                }
                RestaurantWorker worker = getWorkerTypeByString(comboBoxProfession.Text.ToString(), textBoxName.Text, textBoxSurname.Text, dateTimePicker1.Value, textBoxPhone.Text, currAddr, Convert.ToDouble(textBoxSalary.Text), firstParam, textBoxSecond.Text, checkBoxSwear.Checked);
                Workers.Add(worker);
                dataGridAndAllListsUpdate();

            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }

            
        }

        private void textBoxBuilding_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
                return;
            e.Handled = true;
            return;
        }

        private void textBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
                return;
            e.Handled = true;
            return;
        }

        private void comboBoxProfession_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            labelFirst.Visible = true;
            labelSecond.Visible = false;
            textBoxSecond.Visible = false;
            checkBoxSwear.Visible = false;
            if (comboBoxProfession.SelectedIndex == 0)
            {
                textBox1.Visible = false;
                labelFirst.Visible = false;
            }
            else if (comboBoxProfession.SelectedIndex == 1)
            {
                labelFirst.Text = "Чаевые:";
            }
            else if (comboBoxProfession.SelectedIndex == 2)
            {
                labelFirst.Text = "Подчиненных:";
            }
            else if (comboBoxProfession.SelectedIndex == 3)
            {
                labelFirst.Text = "Разряд:";
            }
            else
            {
                checkBoxSwear.Visible = true;
                labelFirst.Text = "Разряд:";
                labelSecond.Text = "Коронное блюдо:";
                labelSecond.Visible = true;
                textBoxSecond.Visible = true;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
