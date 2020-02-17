using System.Collections;
using System.Collections.Generic;

public interface Aggrerate{
    Iterator iterator();
}
public class BookShelf : Aggrerate
{
    private Book[] books;
    private int last=0;
    public BookShelf(int maxSize){
        books=new Book[maxSize];
    }
    public void AddBook(Book book){
        books[last]=book;
        last++;
    }
    public Book GetBookAt(int index){
        return books[index];
    }
    public int GetLength(){
        return last;
    }
    public Iterator iterator(){
        return new BookShelfIterator(this);
    }
}

public class Book{
    public string Name{
        get;
        set;
    }
    public Book(string name){
        Name=name;
    }
}