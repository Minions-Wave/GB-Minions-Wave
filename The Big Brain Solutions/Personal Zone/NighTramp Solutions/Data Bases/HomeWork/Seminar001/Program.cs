string text = "id;r_num_bus;fio_driver;fio_conductor;route;bus_stop_name;\n";

int count = 100;
string[] locations = { "Бульвар", "Улица", "Проспект", "Проезд" };
string[] descriptions = { "Красного Знамени", "Победы", "Ленина", "Молодежи", "Мира", "Дружбы" };

Random random = new Random();
for (int id = 1; id <= count; id++)
{
    string r_num_bus = $"ы{100+id}ыы00";
    string fio_driver = $"ФИО_{id}";
    string fio_conductor = $"ФИО_{100+id}";
    string route = $"Маршрут_с{random.Next(1, 100) + 1}";
    string bus_stop_name = $"{locations[random.Next(locations.Length)]} {descriptions[random.Next(descriptions.Length)]}";
    text += $"{id};{r_num_bus};{fio_driver};{fio_conductor};{route};{bus_stop_name};\n";
}

File.WriteAllText("output.csv", text);
