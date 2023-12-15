using System.ComponentModel;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Security.Cryptography;

List<string> patients = new List<string>();

void addPatient()
{
    Console.Clear();

    Console.WriteLine("Введите данные пациента (ФИО, год рождения, рост, вес, пол)");
    string fullName = Console.ReadLine();
    int birthdate = Convert.ToInt32(Console.ReadLine());
    int height = Convert.ToInt32(Console.ReadLine());
    int weight = Convert.ToInt32(Console.ReadLine());
    string gender = Console.ReadLine();
    float index = (float)height / (float)weight;

    patients.Add($"ФИО: {fullName}, год рождения: {birthdate}, рост: {height}, вес: {weight}, пол: {gender}, ИМТ: {index}");

    Console.WriteLine("Пациент добавлен");

    menu();
}

void getList()
{
    Console.Clear();

    int n = 0;

    foreach (string patient in patients) { Console.WriteLine($"{++n}. {patient}"); }

    Console.WriteLine($"\n1. Вернуться в меню. \n2. Добавить пациента. \n3. Удалить пациента.");

    int action = Convert.ToInt32(Console.ReadLine());
    switch (action)
    {
        case 1:
            menu();
            break;
        case 2:
            addPatient();
            break;
        case 3:
            deletePatient();
            break;
    }
}

void deletePatient()
{
    Console.Clear();

    int n = 0;

    foreach (string patient in patients) { Console.WriteLine($"{++n}. {patient}"); }

    Console.WriteLine($"\nВыберите, какого пациента удалить.");
    int patientDel = Convert.ToInt32(Console.ReadLine());

    patients.RemoveAt(patientDel - 1);

    menu();
}
void menu()
{
    Console.Clear();

    Console.WriteLine($"Выберите действие:\n1. Добавить пациента.\n2. Просмотреть список пациентов.\n3. Удалить пациента.\n4. Выйти");
    int action = Convert.ToInt32(Console.ReadLine());

    switch (action)
    {
        case 1:
            addPatient();
            break;
        case 2:
            getList();
            break;
        case 3:
            deletePatient();
            break;
        case 4:
            Console.Clear();
            Environment.Exit(0);
            break;
    }
}

menu();