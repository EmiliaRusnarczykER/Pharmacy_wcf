using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ECommerceServiceLibrary
{
    // UWAGA: Możesz użyć polecenia "Zmień nazwę" z menu "Refaktoryzacja", aby jednocześnie zmienić nazwę interfejsu "IService1" w kodzie i w pliku konfiguracyjnym.
    [ServiceContract]
    public interface IECommerceService
    {
        ////////////////////CRUD PRODUKTÓW
        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        Product GetProductById(int productId);

        [OperationContract]
        void AddProduct(Product product);

        [OperationContract]
        void UpdateProduct(Product product);

        [OperationContract]
        void DeleteProduct(int productId);
        ////////////////////CRUD PRODUKTÓW

        [OperationContract]
        bool PlaceOrder(Order order);

        [OperationContract]
        User GetUserDetails(int userId);
    }

    // Użyj kontraktu danych, jak pokazano w poniższym przykładzie, aby dodać typy złożone do operacji usługi.
    // Możesz dodać pliki XSD do projektu. Po skompilowaniu projektu, możesz bezpośrednio używać zdefiniowanych tutaj typów danych, z przestrzenią nazw "ECommerceServiceLibrary.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
