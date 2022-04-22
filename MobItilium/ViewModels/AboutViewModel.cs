using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MobItilium.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public List<Phone> Phones { get; set; }
        private string[] phones;
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            Phones = new List<Phone>
        {
            new Phone {Title="0000022827", Company="создать и завести справочник  Категория/подкатегория ", Price="Создание справочника.  Категория/подкатегория + переименовать.Не смогула выбрать/найти  свой состав услуги - регламентные работы по контенту" },
            new Phone {Title="0000030602", Company="Почта на домене технолайт", Price="kosarev@technolight.ru stepanenko@technolight.ru  почта /n technolight.ru не работает FastVps может отказать в обслуживании Сейчас например начал вносить измененияВылезло окно \"Введите код отправленный на почту\" а почта stepanenko@technolight.ru" },
            new Phone {Title="0000000004432", Company="Жопа с каким-то сервисом", Price="Не смогула выбрать/найти  свой состав услуги - регламентные работы по контенту" },
            new Phone {Title="000000003432", Company="Создайте почту", Price="Нужны дополнительные данные: доступы к ЛК, ссылка на документацию. по этой задаче пока никакой конкретики, за которою я бы мог зацепиться. Перевожу на МихаилаДемидов: обращение вытащено из Незабудки" }
        };


        }

        public ICommand OpenWebCommand { get; }
       
    }
    public class Phone
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public string Price { get; set; }
    }
}