using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigRaces bigRaces = new BigRaces();

            Team Russia = new Team(Countries.Россия, bigRaces);
            Team China = new Team(Countries.Китай, bigRaces);
            Team France = new Team(Countries.Франция, bigRaces);
            Team Kazakhstan = new Team(Countries.Казахстан, bigRaces);

            Person Alexander = new Person("Александр", Russia);
            Person Alexei = new Person("Алексей", Russia);
            Person Andrey = new Person("Андрей", Russia);
            Person Boris = new Person("Борис", Russia);
            Person Vasiliy = new Person("Василий", Russia);
            Person Gleb = new Person("Глеб", Russia);
            Person Denis = new Person("Денис", Russia);
            Person Eugene = new Person("Евгений", Russia);
            Person Ivan = new Person("Иван", Russia);
            Person Ilya = new Person("Илья", Russia);
            Person Kirill = new Person("Кирилл", Russia);
            Person Makar = new Person("Макар", Russia);
            Person Nikita = new Person("Никита", Russia);
            Person Oleg = new Person("Олег", Russia);
            Person Paul = new Person("Павел", Russia);

            Person Andre = new Person("Андре", France);
            Person Arno = new Person("Арно", France);
            Person Gustave = new Person("Гюстав", France);
            Person David = new Person("Дэвид", France);
            Person Gerard = new Person("Жерар", France);
            Person Joseph = new Person("Жозеф", France);
            Person Yvon = new Person("Ивон", France);
            Person Karin = new Person("Карин", France);
            Person Colette = new Person("Колетт", France);
            Person Lambert = new Person("Ламберт", France);
            Person Luke = new Person("Люк", France);
            Person Mark = new Person("Марк", France);
            Person Marseilles = new Person("Vfhctkm", France);
            Person Nadine = new Person("Надин", France);
            Person Nicole = new Person("Николь", France);

            Person Wei = new Person("Вэй", China);
            Person Xiuying = new Person("Сюин", China);
            Person Minh = new Person("Минь", China);
            Person Jing = new Person("Цзин", China);
            Person Lei = new Person("Лэй", China);
            Person Yun = new Person("Юн", China);
            Person Ciao = new Person("Чао", China);
            Person Xiulan = new Person("Сюлань", China);
            Person Qiang = new Person("Цян", China);
            Person Gan = new Person("Ган", China);
            Person Guiyin = new Person("Гуйин", China);
            Person Jie = new Person("Цзе", China);
            Person Tao = new Person("Тао", China);
            Person Lee = new Person("Ли", China);
            Person Fan = new Person("Фан", China);

            Person Abai = new Person("Абай", Kazakhstan);
            Person Azamat = new Person("Азамат", Kazakhstan);
            Person Aidar = new Person("Айдар", Kazakhstan);
            Person Bakir = new Person("Бакир", Kazakhstan);
            Person Gabit = new Person("Габит", Kazakhstan);
            Person Daniyar = new Person("Данияр", Kazakhstan);
            Person Erden = new Person("Ерден", Kazakhstan);
            Person Jean = new Person("Жан", Kazakhstan);
            Person Zhupar = new Person("Жупар", Kazakhstan);
            Person Zhangir = new Person("Жангир", Kazakhstan);
            Person Diyar = new Person("Дияр", Kazakhstan);
            Person Danesh = new Person("Данеш", Kazakhstan);
            Person Gafu = new Person("Гафу", Kazakhstan);
            Person Bokey = new Person("Бокей", Kazakhstan);
            Person Bates = new Person("Батес", Kazakhstan);

            Game beach = new Game("Пляж", bigRaces);
            Game sea = new Game("Море", bigRaces);
            Game fishing = new Game("Рыбалка", bigRaces);
            Game slide = new Game("Горка", bigRaces);
            Game postmen = new Game("Почтальоны", bigRaces);
            Game mousetrap = new Game("Мышеловка", bigRaces);
            Game myGame = new Game("Моя игра", bigRaces);


        }
    }
}
