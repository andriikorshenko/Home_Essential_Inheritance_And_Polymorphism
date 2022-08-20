using Task_004;

Console.Write("Введите ключ доступа : ");
string userKey = Console.ReadLine();

String[] proKeys = new string[3] { "Hd12", "de7", "32DS" };
bool proAccessGranted = false;

for (int i = 0; i < proKeys.Length; i++)
{
    if (userKey == proKeys[i])
    {
        proAccessGranted = true;    
        DocumentWorker proAccess = new ProDocumentWorker();
        Console.WriteLine("PRO Access Granted");
        proAccess.OpenDocument();
        proAccess.EditDocument();
        proAccess.SaveDocument();
        break;
    }
    else
    {
        proAccessGranted = false;
    }
}

String[] expertKeys = new string[3] { "de2", "rff4", "43r" };
bool expertAccessGranted = false;

for (int i = 0; i < expertKeys.Length; i++)
{
    if (userKey == expertKeys[i])
    {
        expertAccessGranted = true;
        DocumentWorker expertAccess = new ExpertDocumentWorker();
        Console.WriteLine("EXPERT Access Granted");
        expertAccess.OpenDocument();
        expertAccess.EditDocument();
        expertAccess.SaveDocument();
        break;
    }
    else
    {
        expertAccessGranted = false;
    }
}

if (proAccessGranted == false && expertAccessGranted == false)
{
    DocumentWorker baseAccess = new DocumentWorker();
    Console.WriteLine("Sorry! You entered unavailiable key. Base version is avaliable only.");
    baseAccess.OpenDocument();
    baseAccess.EditDocument();
    baseAccess.SaveDocument();
}