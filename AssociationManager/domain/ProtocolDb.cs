
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class ProtocolDb {

    /**
     * 
     */
    public ProtocolDb() {
    }

    /**
     * 
     */
    private int year;

    /**
     * 
     */
    private String association;

    /**
     * 
     */
    private String associationID;

    public int Year
    {
        get
        {
            return year;
        }

        set
        {
            year = value;
        }
    }

    public string Association
    {
        get
        {
            return association;
        }

        set
        {
            association = value;
        }
    }

    public string AssociationID
    {
        get
        {
            return associationID;
        }

        set
        {
            associationID = value;
        }
    }
    public List<Protocol> protocols()
    {
        return null;
    }
}