using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        // Переменные для хранения состояния калькулятора
        private string currentInput = "";
        private string operation = "";
        private double firstNumber = 0;
        private bool isNewOperation = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Подключаем обработчики для ЦИФРОВЫХ кнопок
            button0.Click += ButtonNumber_Click;
            button1.Click += ButtonNumber_Click;
            button2.Click += ButtonNumber_Click;
            button3.Click += ButtonNumber_Click;
            button4.Click += ButtonNumber_Click;
            button5.Click += ButtonNumber_Click;
            button6.Click += ButtonNumber_Click;
            button7.Click += ButtonNumber_Click;
            button8.Click += ButtonNumber_Click;
            button9.Click += ButtonNumber_Click;
            buttonDecimal.Click += ButtonNumber_Click;

            // Подключаем обработчики для ОПЕРАЦИЙ
            buttonPlus.Click += ButtonOperation_Click;
            buttonMinus.Click += ButtonOperation_Click;
            buttonMultiply.Click += ButtonOperation_Click;
            buttonDivide.Click += ButtonOperation_Click;

            // Подключаем обработчики для СПЕЦИАЛЬНЫХ кнопок
            buttonEquals.Click += ButtonEquals_Click;
            buttonClear.Click += ButtonClear_Click;
            buttonBackspace.Click += ButtonBackspace_Click;
            buttonPercent.Click += ButtonPercent_Click;

            // Настраиваем окно
            this.KeyPreview = true;
        }

        // ОБРАБОТЧИК для всех ЦИФРОВЫХ кнопок (0-9)
        private void ButtonNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Если началась новая операция, очищаем дисплей
            if (isNewOperation)
            {
                textBoxDisplay.Text = "";
                isNewOperation = false;
            }

            // Проверка для точки: нельзя добавить вторую точку
            if (button.Text == "." && currentInput.Contains("."))
            {
                return; // Выходим, если точка уже есть
            }

            // Добавляем символ к текущему вводу
            currentInput += button.Text;

            // Отображаем на дисплее
            textBoxDisplay.Text += button.Text;
        }

        // ОБРАБОТЧИК для ОПЕРАЦИЙ (+, -, ×, ÷)
        private void ButtonOperation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Проверяем, есть ли число для операции
            if (!string.IsNullOrEmpty(currentInput))
            {
                // Сохраняем выбранную операцию
                operation = button.Text;

                // Сохраняем первое число
                firstNumber = Convert.ToDouble(currentInput);

                // Добавляем в историю
                AddToHistory($"{firstNumber} {operation}");

                // Добавляем операцию на дисплей
                textBoxDisplay.Text += " " + operation + " ";

                // Сбрасываем текущий ввод для второго числа
                currentInput = "";
            }
        }

        // ОБРАБОТЧИК для кнопки "="
        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли что вычислять
            if (!string.IsNullOrEmpty(currentInput) && !string.IsNullOrEmpty(operation))
            {
                // Получаем второе число
                double secondNumber = Convert.ToDouble(currentInput);
                double result = 0;

                // Выполняем операцию в зависимости от выбранной
                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;

                    case "-":
                        result = firstNumber - secondNumber;
                        break;

                    case "×":
                        result = firstNumber * secondNumber;
                        break;

                    case "÷":
                        // Проверка деления на ноль
                        if (secondNumber != 0)
                        {
                            result = firstNumber / secondNumber;
                        }
                        else
                        {
                            textBoxDisplay.Text = "Ошибка: деление на 0";
                            AddToHistory("ОШИБКА: Деление на 0");
                            ResetCalculator();
                            return;
                        }
                        break;
                }

                // Добавляем в историю
                AddToHistory($"{secondNumber} = {result}");

                // Показываем результат
                textBoxDisplay.Text = result.ToString();

                // Сохраняем результат как текущий ввод
                currentInput = result.ToString();

                // Сбрасываем операцию
                operation = "";

                // Устанавливаем флаг новой операции
                isNewOperation = true;
            }
        }

        // ОБРАБОТЧИК для кнопки "C" (очистка)
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            // Добавляем в историю
            AddToHistory("--- Очистка ---");

            // Сбрасываем калькулятор
            ResetCalculator();

            // Очищаем дисплей
            textBoxDisplay.Text = "";
        }

        // ОБРАБОТЧИК для кнопки "←" (backspace)
        private void ButtonBackspace_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли что удалять
            if (!string.IsNullOrEmpty(currentInput))
            {
                // Удаляем последний символ
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
                textBoxDisplay.Text = textBoxDisplay.Text.Substring(0, textBoxDisplay.Text.Length - 1);

                // Добавляем в историю
                AddToHistory("Удален символ");
            }
        }

        // ОБРАБОТЧИК для кнопки "%" (процент)
        private void ButtonPercent_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли число
            if (!string.IsNullOrEmpty(currentInput))
            {
                // Делим число на 100
                double number = Convert.ToDouble(currentInput);
                number = number / 100;

                // Добавляем в историю
                AddToHistory($"Процент: {currentInput}% = {number}");

                // Обновляем текущий ввод
                currentInput = number.ToString();

                // Показываем результат
                textBoxDisplay.Text = currentInput;
            }
        }

        // МЕТОД для добавления записи в историю
        private void AddToHistory(string text)
        {
            // Проверяем, существует ли textBoxHistory
            if (textBoxHistory != null)
            {
                textBoxHistory.AppendText($"[{DateTime.Now:HH:mm:ss}] {text}" + Environment.NewLine);
            }
        }

        // МЕТОД для сброса калькулятора
        private void ResetCalculator()
        {
            currentInput = "";
            operation = "";
            firstNumber = 0;
            isNewOperation = true;
        }

        // ОБРАБОТКА ВВОДА С КЛАВИАТУРЫ
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            // Обработка цифр
            if (char.IsDigit(e.KeyChar))
            {
                ButtonNumber_Click(new Button { Text = e.KeyChar.ToString() }, EventArgs.Empty);
            }
            // Обработка операций
            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
            {
                string op = e.KeyChar == '*' ? "×" : e.KeyChar == '/' ? "÷" : e.KeyChar.ToString();
                ButtonOperation_Click(new Button { Text = op }, EventArgs.Empty);
            }
            // Обработка других клавиш
            else if (e.KeyChar == '=' || e.KeyChar == (char)Keys.Enter)
            {
                ButtonEquals_Click(this, EventArgs.Empty);
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                ButtonClear_Click(this, EventArgs.Empty);
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                ButtonBackspace_Click(this, EventArgs.Empty);
            }
            else if (e.KeyChar == '.')
            {
                ButtonNumber_Click(new Button { Text = "." }, EventArgs.Empty);
            }
            else if (e.KeyChar == '%')
            {
                ButtonPercent_Click(this, EventArgs.Empty);
            }

            e.Handled = true;
        }

        private void textBoxHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}