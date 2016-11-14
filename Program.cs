using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_CS_5._1
{
    struct Article
    { 
        int productCode;
        string productName;
        double productPrice;
    }
    struct Client
    { 
        int clientCode;
        string clientFullName;
        string clientAddress;
        string clientPhone;
        string clientNumberOfOrders;//количе-ство заказов осуществленных клиентом
        string clientTotalAmountOfOrders;//общая сумма заказов клиента
    }
    struct RequestItem
    { 
        public string Product;
        public int NumberOfProducts;
    }
    struct Request
    {
          public Request(int _orderCode, string _clientName, DateTime _orderDate, LinkedList<RequestItem> _listOfOrderedProducts)
          {
              orderCode = _orderCode;
              clientName = _clientName;
              orderDate = _orderDate;
              listOfOrderedProducts = _listOfOrderedProducts;
          }
          int orderCode;
          string clientName;
          DateTime orderDate;
          LinkedList<RequestItem> listOfOrderedProducts;//перечень заказанных товаров
          double orderAmount;//сумма заказа (реализовать вычисляемым свойством).
          double order
          {
              get { return orderAmount; }
              set {                        
                       foreach(RequestItem req in listOfOrderedProducts)
                            {
                                orderAmount += req.Product * req.NumberOfProducts;
                            }
                  }
          }
    }
    class YTP//new class
    {
	byte TP;
    }
    class YsTPs//new class
    {
	byte TP;
    }
    class Control
    {
        LinkedList<Client> Clients;
        LinkedList<Request> Requests;
        LinkedList<Article> Articles;
        Control() { }
        public void AddNewRequest(int _orderCode, string _clientName, DateTime _orderDate, LinkedList<RequestItem> _listOfOrderedProducts)
        {
            Request req;
        }
    }
    class Program
    {
        static void Main()
        {

        }
    }
}
