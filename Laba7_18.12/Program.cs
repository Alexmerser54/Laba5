using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Laba7_18._12
{

    struct Note
    {
        string name;
        string lastname;
        string phone;
        int[] birthDate;

        public Note(string name, string lastname, string phone, int[] birthDate)
        {
            this.name = name;
            this.lastname = lastname;
            this.phone = phone;
            this.birthDate = birthDate;
        }

        public string Name => name;
        public string Lastname => lastname;
        public string Phone => phone;
        public int[] BirthDate => birthDate;

        public override string ToString()
        {
            return $"{Name} {Lastname}, {Phone}, {BirthDate[0]}.{BirthDate[1]}.{BirthDate[2]}";
        }

    }

    class Program
    {


        public static Note ParseStringToNote(string str)
        {
            string[] tmp = str.Split(new string[] { ", " }, StringSplitOptions.None);

            int[] date = new int[3];

            string[] name = tmp[0].Split(' ');


            string[] dateTmp = tmp[2].Split('.');

            for (int j = 0; j < date.Length; j++)
            {
                date[j] = Convert.ToInt32(dateTmp[j]);
            }

            return new Note(name[0], name[1], tmp[1], date);
        }

        public static Note[] FileToNotes(string fileName, int count)
        {
            Note[] people = new Note[count];

            string[] lines = File.ReadAllLines(fileName);

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = ParseStringToNote(lines[i]);

            }
            return people;
        }



        public static void WriteNotes(Note[] people, string filename)
        {
            foreach (var item in people)
            {
                File.AppendAllText(filename, item.ToString() + Environment.NewLine);
            }
        }


        static void Main(string[] args)
        {
            Note[] people = new Note[8];
            string input;

            Console.WriteLine("Выберете действие:");
            Console.WriteLine("1) Записать 8 человек в файл");
            Console.WriteLine("2) Считать данные из файла");
            Console.WriteLine("3) Поиск человека по номеру");

            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:

                    File.WriteAllText("note.txt", "");

                    for (int i = 0; i < people.Length; i++)
                    {
                    A: try
                        {
                            input = Console.ReadLine();
                            people[i] = ParseStringToNote(input);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Данные введены в неверном формате. Введите данные в верном формате");
                            goto A;
                        }

                    }

                    for (int i = 0; i < people.Length; i++)
                    {
                        for (int j = i + 1; j < people.Length; j++)
                        {
                            if (people[i].BirthDate[2] > people[j].BirthDate[2] ||
                                (people[i].BirthDate[2] > people[j].BirthDate[2] && people[i].BirthDate[1] > people[j].BirthDate[1]) ||
                                (people[i].BirthDate[2] > people[j].BirthDate[2] && people[i].BirthDate[1] > people[j].BirthDate[1] && people[i].BirthDate[0] > people[j].BirthDate[0]))
                            {
                                Note tmp = people[i];
                                people[i] = people[j];
                                people[j] = tmp;
                            }
                        }
                    }

                    WriteNotes(people, "note.txt");


                    break;
                case 2:

                    foreach (var item in File.ReadAllLines("note.txt"))
                    {
                        Console.WriteLine(item);
                    }

                    break;
                case 3:

                    string number = Console.ReadLine();

                    string[] lines = File.ReadAllLines("note.txt");

                    for (int i = 0; i < people.Length; i++)
                    {
                        people[i] = ParseStringToNote(lines[i]);
                    }

                    bool flag = false;

                    foreach (var item in people)
                    {
                        if (item.Phone == number)
                        {
                            Console.WriteLine(item.ToString());
                            flag = true;
                        }
                    }

                    if (flag == false) Console.WriteLine("Нет людей с таким номером");

                    break;
                default:
                    break;
            }


        }
    }
}
