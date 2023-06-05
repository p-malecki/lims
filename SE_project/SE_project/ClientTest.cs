
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ClientTest {



    public ClientTest(int id, int orderId, string result, int testId)
    {
    }

    private int _id;
    private int _orderID;
    private int _testID;
    private string _result;

    protected int OrderID { get => _orderID; set => _orderID = value; }
    protected string Result { get => _result; set => _result = value; }
}