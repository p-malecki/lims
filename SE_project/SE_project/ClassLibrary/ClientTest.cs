
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public class ClientTest {


    public ClientTest(int id, int orderId, string result, int testId, bool status = false)
    {
        _id = id;
        _orderID = orderId; 
        _result = result;   
        _testID = testId;
        _status = status;
    }
    public ClientTest() { }
    private int _id;
    private int _orderID;
    private int _testID;
    private string _result;
    private bool _status;

    public int OrderID { get => _orderID; set => _orderID = value; }
    public string Result { get => _result; set => _result = value; }
    public int ID { get => _id; set => _id = value; }
    public int TestID { get => _testID; set => _testID = value; }
    public bool Status { get => _status; set => _status = value; }
}