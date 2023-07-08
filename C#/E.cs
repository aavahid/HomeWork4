string[] text = { "Salam", "Dunya", "Necesen", "Salam", "Dunya", "Cavab" };

foreach (string ClearText in text.Distinct())
{
    Console.Write(ClearText + " ");
}