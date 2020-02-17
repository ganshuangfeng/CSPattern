using System.Collections;
using System.Collections.Generic;
using System;

public interface Iterator
{
    bool HasNext();
    Object Next();
}

public class BookShelfIterator : Iterator
{
    private BookShelf bookShelf;
    private int index;
    public BookShelfIterator(BookShelf shelf){
        bookShelf=shelf;
        index=0;
    }
    public Object Next(){
        Book book=bookShelf.GetBookAt(index);
        index++;
        return book;
    }
    public bool HasNext(){
        if(index<bookShelf.GetLength()){
            return true;
        }else{
            return false;
        }
    }
}