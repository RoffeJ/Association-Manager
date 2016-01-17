
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class Member {

    /**
     * 
     */
    public Member() {
    }

    /**
     * 
     */
    private String name;

    /**
     * 
     */
    private String title;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    protected string Title
    {
        get
        {
            return title;
        }

        set
        {
            title = value;
        }
    }
}