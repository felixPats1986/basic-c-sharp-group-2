namespace Assignment2;

public class PhotoBook
{
    public int numPages;

    public PhotoBook()
    {
        numPages = 16;
    }
    
    public PhotoBook(int numPages)
    {
        this.numPages = numPages;
    }

    public int GetNumberPages()
    {
        return numPages;
    }

}