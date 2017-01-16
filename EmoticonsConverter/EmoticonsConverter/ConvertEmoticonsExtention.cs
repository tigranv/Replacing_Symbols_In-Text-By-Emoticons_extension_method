namespace EmoticonsConverter
{
    public static class ConvertEmoticonsExtention
    {
        // Extention method 
        public static string ConvertEmoticons(this string value)
        {
            string NewValue = string.Empty;
            for (int i = 0; i < value.Length; i++)
            {
                if (i != value.Length - 1)
                {
                    switch (value.Substring(i, 2))
                    {
                        case ":)":
                            NewValue += "\u263B";
                            i++;
                            break;
                        case ":(":
                            NewValue += "\u2639";
                            i++;
                            break;
                        default:
                            NewValue += value[i].ToString();
                            break;
                    }
                }
                else
                {
                    NewValue += value[i].ToString();
                    break;
                }
            }
            return NewValue;
        }
    }
}
