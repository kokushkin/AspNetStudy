
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

[MetadataType(typeof(Order_DetailMetadata))]
public partial class Order_Detail { }

[DisplayName("Детали заказа")]
public class Order_DetailMetadata { }


[MetadataType(typeof(ProductMetadata))]
public partial class Product
{
    partial void OnUnitsInStockChanging(short? value)
    {
        if (value % 2 == 1) throw new ValidationException("Количество товара должно быть четным");
    }
}

public class ProductMetadata
{
    [DisplayName("В наличии")]
    [Required(ErrorMessage = "Вы должны ввести, сколько товара у вас есть в наличии")]
    [Range(0, 100)]
    public object UnitsInStock { get; set; }

    [DisplayName("Цена")]
    public object UnitPrice { get; set; }

    [ScaffoldColumn(false)]
    public object SupplierID { get; set; }
}


[MetadataType(typeof(CustomerMetadata))]
public partial class Customer
{
}

[ScaffoldTable(false)]
public class CustomerMetadata
{
}


[MetadataType(typeof(OrderMetadata))]
public partial class Order
{
}

public class OrderMetadata
{
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    public object OrderDate { get; set; }

    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    public object RequiredDate { get; set; }

    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    public object ShippedDate { get; set; }

    [UIHint("REDText")]
    public object ShipName { get; set; }
}