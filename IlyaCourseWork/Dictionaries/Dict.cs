namespace IlyaCourseWork.Dictionaries
{
    public static class Dict
    {
        public static string GetValue(string key)
        {
            return pageName[key];
        }

        static Dictionary<string, string> pageName = new Dictionary<string, string>
        {
            ["History"] = "История",
            ["Missions"] = "Миссии и достижения",
            ["Responsibility"] = "История",
            ["Rewards"] = "Награды и достижения",
            ["Security"] = "Безопасность",
            ["Team"] = "Команда",
            ["Contacts"] = "Контакты",
            ["Form"] = "Резюме",
            ["Schools"] = "Программы для школьников",
            ["FAQ"] = "Вопросы и ответы",
            ["Gallery"] = "Галерея",
            ["Guide"] = "Техническое руководство",
            ["Lithium"] = "Литье и формовка",
            ["Metal"] = "Обработка металла",
            ["Product"] = "Продукты",
        };
    }
}
