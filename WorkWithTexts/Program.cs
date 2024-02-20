namespace WorkWithTexts
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(TextFormat.NameFormat("jevLAmPIJA"));
            Console.WriteLine();

            //string[] phoneNumbers = {"+37063500697", "863500697", "37063500697", "0037063500697", "63500697",
            //                        "863500697", "8 63500697", "8635 00697", "8-63500697", "8635-00697", "8(635)00697",
            //                        "8(635) 00697", "8 (635) 00697", "63500697", "63500697", "635 00697", "63500697",
            //                        "635-00697", "(635)00697", "(635) 00697", "(635) 00697", "37063500697", "370 63500697",
            //                        "370 635 00697", "370-63500697", "370-635-00697", "370(635)00697", "370 (635) 00697",
            //                        "370 (635) 00697", "+37063500697", "+370 63500697", "+370 635 00697", "+370-63500697",
            //                        "+370-635-00697", "+370(635)00697", "+370 (635) 00697", "+370 (635) 00697", "0037063500697",
            //                        "00370 63500697", "00370 635 00697", "00370-63500697", "00370-635-00697","00370(635)00697",
            //                        "00370 (635) 00697", "00370 (635) 00697" };

            Console.WriteLine("Enter phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine(TextFormat.PhoNoFormat(phoneNumber));
            Console.WriteLine();

            Console.WriteLine("Enter eMail: ");
            string eMail = Console.ReadLine();
            Console.WriteLine(TextFormat.EMailFormat(eMail));
            Console.WriteLine();
        }
    }
}
