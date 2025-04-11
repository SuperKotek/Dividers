using MathHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Delitili
{
    /// <summary>
    /// Главная форма приложения
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Текущая выбранная функция
        /// </summary>
        int Predfunc = 0;
        
        /// <summary>
        /// Массив меток для навигации
        /// </summary>
        Label[] labelss = new Label[7];

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            labelss[0] = label1;
            labelss[1] = label2;
            labelss[2] = label3;
            labelss[3] = label4;
            labelss[4] = label5;
            labelss[5] = label6;
            labelss[6] = label7;
        }

        /// <summary>
        /// Показать/скрыть элементы для выбранной функции
        /// </summary>
        private void ShowHideFunc(int labl, int parmtr)
        {
            switch (labl)
            {
                case 1:
                    labname1.Visible = parmtr == 1;
                    namnam.Visible = parmtr == 1;
                    namnam1.Visible = parmtr == 1;
                    namnam2.Visible = parmtr == 1;
                    textBox1.Visible = parmtr == 1;
                    textBox2.Visible = parmtr == 1;
                    button1.Visible = parmtr == 1;
                    break;
                case 2:
                    labname2.Visible = parmtr == 1;
                    namnum.Visible = parmtr == 1;
                    namnum1.Visible = parmtr == 1;
                    namnum2.Visible = parmtr == 1;
                    namnum3.Visible = parmtr == 1;
                    textBox3.Visible = parmtr == 1;
                    textBox4.Visible = parmtr == 1;
                    textBox5.Visible = parmtr == 1;
                    button2.Visible = parmtr == 1;
                    break;
                case 3:
                    labname3.Visible = parmtr == 1;
                    nimnim.Visible = parmtr == 1;
                    nimnim1.Visible = parmtr == 1;
                    nimnim2.Visible = parmtr == 1;
                    textBox6.Visible = parmtr == 1;
                    textBox7.Visible = parmtr == 1;
                    button3.Visible = parmtr == 1;
                    break;
                case 4:
                    labname4.Visible = parmtr == 1;
                    nimnam.Visible = parmtr == 1;
                    nimnam1.Visible = parmtr == 1;
                    nimnam2.Visible = parmtr == 1;
                    textBox8.Visible = parmtr == 1;
                    textBox9.Visible = parmtr == 1;
                    button4.Visible = parmtr == 1;
                    break;
                case 5:
                    labname5.Visible = parmtr == 1;
                    nimnum.Visible = parmtr == 1;
                    nimnum1.Visible = parmtr == 1;
                    nimnum2.Visible = parmtr == 1;
                    textBox10.Visible = parmtr == 1;
                    textBox11.Visible = parmtr == 1;
                    button5.Visible = parmtr == 1;
                    break;
                case 6:
                    labname6.Visible = parmtr == 1;
                    nymnym.Visible = parmtr == 1;
                    nymnym1.Visible = parmtr == 1;
                    nymnym2.Visible = parmtr == 1;
                    nymnym3.Visible = parmtr == 1;
                    textBox12.Visible = parmtr == 1;
                    textBox13.Visible = parmtr == 1;
                    textBox14.Visible = parmtr == 1;
                    button6.Visible = parmtr == 1;
                    break;
                case 7:
                    labname7.Visible = parmtr == 1;
                    nymnam.Visible = parmtr == 1;
                    nymnam1.Visible = parmtr == 1;
                    nymnam2.Visible = parmtr == 1;
                    nymnam3.Visible = parmtr == 1;
                    textBox15.Visible = parmtr == 1;
                    textBox16.Visible = parmtr == 1;
                    textBox17.Visible = parmtr == 1;
                    button7.Visible = parmtr == 1;
                    break;
            }
        }

        /// <summary>
        /// Изменить цвет выбранной метки
        /// </summary>
        private void ColorChange(int labl, Label[] a)
        {
            for (int i = 0; i < 7; i++)
            {
                a[i].ForeColor = i == labl - 1 ? Color.FromArgb(15, 15, 80) : Color.FromArgb(40, 40, 40);
            }
        }

        /// <summary>
        /// Обработчик клика по метке 1
        /// </summary>
        private void label1_Click(object sender, EventArgs e)
        {
            ShowHideFunc(Predfunc, 0);
            Predfunc = 1;
            ShowHideFunc(Predfunc, 1);
            ColorChange(1, labelss);
        }

        /// <summary>
        /// Обработчик клика по метке 2
        /// </summary>
        private void label2_Click(object sender, EventArgs e)
        {
            ShowHideFunc(Predfunc, 0);
            Predfunc = 2;
            ShowHideFunc(Predfunc, 1);
            ColorChange(2, labelss);
        }

        /// <summary>
        /// Обработчик клика по метке 3
        /// </summary>
        private void label3_Click(object sender, EventArgs e)
        {
            ShowHideFunc(Predfunc, 0);
            Predfunc = 3;
            ShowHideFunc(Predfunc, 1);
            ColorChange(3, labelss);
        }

        /// <summary>
        /// Обработчик клика по метке 4
        /// </summary>
        private void label4_Click(object sender, EventArgs e)
        {
            ShowHideFunc(Predfunc, 0);
            Predfunc = 4;
            ShowHideFunc(Predfunc, 1);
            ColorChange(4, labelss);
        }

        /// <summary>
        /// Обработчик клика по метке 5
        /// </summary>
        private void label5_Click(object sender, EventArgs e)
        {
            ShowHideFunc(Predfunc, 0);
            Predfunc = 5;
            ShowHideFunc(Predfunc, 1);
            ColorChange(5, labelss);
        }

        /// <summary>
        /// Обработчик клика по метке 6
        /// </summary>
        private void label6_Click(object sender, EventArgs e)
        {
            ShowHideFunc(Predfunc, 0);
            Predfunc = 6;
            ShowHideFunc(Predfunc, 1);
            ColorChange(6, labelss);
        }

        /// <summary>
        /// Обработчик клика по метке 7
        /// </summary>
        private void label7_Click(object sender, EventArgs e)
        {
            ShowHideFunc(Predfunc, 0);
            Predfunc = 7;
            ShowHideFunc(Predfunc, 1);
            ColorChange(7, labelss);
        }

        /// <summary>
        /// Обработчик кнопки для поиска всех делителей
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox1.Text, out int number) || number <= 0)
                {
                    textBox2.Text = "Ошибка: Введите целое положительное число > 0";
                    return;
                }
                
                var divisors = NumberHelper.GetAllDivisors(number);
                textBox2.Text = string.Join(", ", divisors);
            }
            catch (Exception ex)
            {
                textBox2.Text = $"Ошибка: {GetErrorMessage(ex)}";
            }
        }

        /// <summary>
        /// Обработчик кнопки для поиска чисел с 5 делителями
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox3.Text, out int m) || !int.TryParse(textBox4.Text, out int n))
                {
                    textBox5.Text = "Ошибка: Введите корректные целые числа";
                    return;
                }

                if (m > n)
                {
                    textBox5.Text = "Начало диапазона должно быть меньше конца";
                    return;
                }

                var numbers = NumberHelper.FindNumbersWith5Divisors(m, n);
                textBox5.Text = numbers.Count > 0 ? string.Join(", ", numbers) : "Числа с 5 делителями не найдены";
            }
            catch (Exception ex)
            {
                textBox5.Text = $"Ошибка: {GetErrorMessage(ex)}";
            }
        }

        /// <summary>
        /// Обработчик кнопки для разложения на множители
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox6.Text, out int number) || number <= 0)
                {
                    textBox7.Text = "Ошибка: Введите целое положительное число > 0";
                    return;
                }

                var factors = NumberHelper.Factorize(number);
                string result = "";
                foreach (var factor in factors)
                {
                    result += $"{factor.Key}^{factor.Value} × ";
                }
                textBox7.Text = result.Trim('×', ' ');
            }
            catch (Exception ex)
            {
                textBox7.Text = $"Ошибка: {GetErrorMessage(ex)}";
            }
        }

        /// <summary>
        /// Обработчик кнопки для генерации первых N простых чисел
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox8.Text, out int count) || count <= 0)
                {
                    textBox9.Text = "Ошибка: Введите целое положительное число > 0";
                    return;
                }

                var primes = NumberHelper.GenerateFirstPrimes(count);
                textBox9.Text = string.Join(", ", primes);
            }
            catch (Exception ex)
            {
                textBox9.Text = $"Ошибка: {GetErrorMessage(ex)}";
            }
        }

        /// <summary>
        /// Обработчик кнопки для решета Эратосфена
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox10.Text, out int count) || count <= 0)
                {
                    textBox11.Text = "Ошибка: Введите целое положительное число > 0";
                    return;
                }

                var primes = NumberHelper.GeneratePrimesSieve(count);
                textBox11.Text = string.Join(", ", primes);
            }
            catch (Exception ex)
            {
                textBox11.Text = $"Ошибка: {GetErrorMessage(ex)}";
            }
        }

        /// <summary>
        /// Обработчик кнопки для нахождения НОД
        /// </summary>
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox12.Text, out int a) || !int.TryParse(textBox13.Text, out int b))
                {
                    textBox14.Text = "Ошибка: Введите корректные целые числа";
                    return;
                }

                if (a == 0 && b == 0)
                {
                    textBox14.Text = "Ошибка: Оба числа не могут быть нулями";
                    return;
                }

                int gcd = NumberHelper.FindGCD(a, b);
                textBox14.Text = gcd.ToString();
            }
            catch (Exception ex)
            {
                textBox14.Text = $"Ошибка: {GetErrorMessage(ex)}";
            }
        }

        /// <summary>
        /// Обработчик кнопки для нахождения НОК
        /// </summary>
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox15.Text, out int a) || !int.TryParse(textBox16.Text, out int b))
                {
                    textBox17.Text = "Ошибка: Введите корректные целые числа";
                    return;
                }

                if (a == 0 || b == 0)
                {
                    textBox17.Text = "Ошибка: Числа не могут быть нулями";
                    return;
                }

                int lcm = NumberHelper.FindLCM(a, b);
                textBox17.Text = lcm.ToString();
            }
            catch (Exception ex)
            {
                textBox17.Text = $"Ошибка: {GetErrorMessage(ex)}";
            }
        }

        /// <summary>
        /// Преобразование исключения в сообщение об ошибке
        /// </summary>
        private string GetErrorMessage(Exception ex)
        {
            switch (ex)
            {
                case FormatException _:
                    return "Некорректный формат числа";
                case OverflowException _:
                    return "Число слишком большое или слишком маленькое";
                case ArgumentException _:
                    return "Недопустимые аргументы: " + ex.Message.Replace("Value does not fall within the expected range.", 
                                                                          "Значение недопустимо.");
                default:
                    return ex.Message;
            }
        }

        /// <summary>
        /// Обработчик кнопки "Инструкция"
        /// </summary>
        private void button8_Click(object sender, EventArgs e)
        {
            string instruction = @"
    ИНСТРУКЦИЯ ПО ИСПОЛЬЗОВАНИЮ ПРОГРАММЫ

    1. Нахождение всех делителей числа:
    - Введите целое положительное число
    - Пример: 12 → 1, 2, 3, 4, 6, 12

    2. Нахождение чисел с 5 делителями в диапазоне:
    - Введите два целых числа (начало и конец диапазона)
    - Пример: 1-100 → 16, 81

    3. Разложение на простые множители:
    - Введите целое положительное число (>1)
    - Пример: 180 → 2²×3²×5

    4. Генерация первых N простых чисел:
    - Введите количество простых чисел
    - Пример: 5 → 2, 3, 5, 7, 11

    5. Генерация простых чисел до N (решето Эратосфена):
    - Введите верхнюю границу диапазона
    - Пример: 10 → 2, 3, 5, 7

    6. Нахождение НОД двух чисел:
    - Введите два целых числа
     - Пример: 48 и 180 → 12

    7. Нахождение НОК двух чисел:
    - Введите два целых числа
    - Пример: 12 и 15 → 60

    ОШИБКИ:
    - Если введено нечисловое значение → 'Ошибка: Некорректный формат числа'
    - Если введено отрицательное число → 'Ошибка: Введите положительное число'
    - Если введен ноль → 'Ошибка: Введите число больше нуля'
    ";

            MessageBox.Show(instruction, "Инструкция по использованию", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Остальные методы TextChanged оставлены без summary по требованию
        private void textBox8_TextChanged(object? sender, EventArgs e) { }
        private void textBox9_TextChanged(object? sender, EventArgs e) { }
        private void textBox10_TextChanged(object? sender, EventArgs e) { }
        private void textBox11_TextChanged(object? sender, EventArgs e) { }
        private void textBox12_TextChanged(object? sender, EventArgs e) { }
        private void textBox13_TextChanged(object? sender, EventArgs e) { }
        private void textBox14_TextChanged(object? sender, EventArgs e) { }
        private void textBox15_TextChanged(object? sender, EventArgs e) { }
        private void textBox16_TextChanged(object? sender, EventArgs e) { }
        private void textBox17_TextChanged(object? sender, EventArgs e) { }
        private void textBox1_TextChanged(object? sender, EventArgs e) { }
        private void textBox2_TextChanged(object? sender, EventArgs e) { }
        private void textBox3_TextChanged(object? sender, EventArgs e) { }
        private void textBox4_TextChanged(object? sender, EventArgs e) { }
        private void textBox5_TextChanged(object? sender, EventArgs e) { }
        private void textBox6_TextChanged(object? sender, EventArgs e) { }
        private void textBox7_TextChanged(object? sender, EventArgs e) { }
    }
}