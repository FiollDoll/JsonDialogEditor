namespace DialogEditor;

public class LanguageSetting
{
    public string ru { get; set; }
    public string en { get; set; }

    public LanguageSetting()
    {
        ru = "";
        en = "";
    }
    
    public LanguageSetting(string russianText, string englishText)
    {
        ru = russianText;
        en = englishText;
    }
}