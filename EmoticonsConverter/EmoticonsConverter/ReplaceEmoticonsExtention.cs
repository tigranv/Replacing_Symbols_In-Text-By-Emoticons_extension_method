namespace EmoticonsConverter
{
    public static class ReplaceEmoticonsExtention
    {
        // Extention method 
        public static string ReplaceEmoticons(this string value)
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
                        case "->":
                            NewValue += "\u261B";
                            i++;
                            break;
                        case "<-":
                            NewValue += "\u261A";
                            i++;
                            break;
                        default:
                            NewValue += value[i].ToString();
                            break;
                    }
                    //switch (value.Substring(i, 3))
                    //{
                    //    case ":-)":
                    //        NewValue += "\u263B";
                    //        i+=2;
                    //        break;
                    //    case ":-(":
                    //        NewValue += "\u2639";
                    //        i+=2;
                    //        break;
                    //    case "-->":
                    //        NewValue += "\u261B";
                    //        i++;
                    //        break;
                    //    case "<--":
                    //        NewValue += "\u261A";
                    //        i++;
                    //        break;
                    //    default:
                    //        NewValue += value[i].ToString();
                    //        break;
                    //}
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
