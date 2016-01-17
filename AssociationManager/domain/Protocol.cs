
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class Protocol {

    /**
     * 
     */
    public Protocol() {
    }

    /**
     * 
     */
    private String header;

    /**
     * 
     */
    private int id;

    public string Header
    {
        get
        {
            return header;
        }

        set
        {
            header = value;
        }
    }

    public int Id
    {
        get
        {
            return id;
        }

        set
        {
            id = value;
        }
    }

    /**
    *
    */
    public List<Member> members()
    {
        return null;
    }

    /**
    *
    */
    public List<Paragraf> paragrafs()
    {
        return null;
    }

    /**
    *
    */
    public Footer footer()
    {
        return null;
    }
}