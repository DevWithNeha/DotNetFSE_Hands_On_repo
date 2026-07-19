using FactoryMethodPattern;

namespace factoryMethodPattern
{
    public class DocumentFactory
    {
        public static IDocument CreateDocument(string type)
        {
            if (type == "PDF")
                return new PdfDocument();

            if (type == "WORD")
                return new WordDocument();

            return null;
        }
    }
}