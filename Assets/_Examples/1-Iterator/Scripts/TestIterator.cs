using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestIterator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BookShelf bookShelf=new BookShelf(20);
        for(int i=0;i<5;i++){
            string bookName="book"+i;
            Book book=new Book(bookName);
            bookShelf.AddBook(book);
        }
        Iterator it=bookShelf.iterator();
        while(it.HasNext()){
            Book book=(Book)it.Next();
            DebugHelper.Log(book.Name,Color.red);
        }
    }
}
