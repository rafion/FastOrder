using FastOrder.Api.Models;
using FastOrder.Api.Models.Input;
using FastOrder.Domain.Models;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.OpenApi.Extensions;

namespace FastOrder.Api.Assemblers
{
    public static class ItemAssemblerExt
    {
        public static Item ToDomainObject(this ItemInput itemInput)
        {

            return new Item
            {
                Id = itemInput.Id,
                Name = itemInput.Name,
                Sku = itemInput.Sku,
                Price = itemInput.Price,
                CostPrice = itemInput.CostPrice,
                Model = itemInput.Model,
                Reference = itemInput.Reference,
                Ean = itemInput.Ean,
                StockQuantity = itemInput.StockQuantity,
                Status = itemInput.Status,
                Unit = itemInput.Unit,


            };

        }

        public static ItemModel ToModel(this Item item)
        {
            return new ItemModel { 
                Id = item.Id,
                Name = item.Name,
                Sku = item.Sku,
                Reference = item.Reference,
                Unit = item.Unit,
                Model = item.Model,
                Price = item.Price,
                CostPrice = item.CostPrice,
                StockQuantity = item.StockQuantity,
                Status = item.Status,
                ItemType = item.ItemType,
                StatusName = item.Status.GetDisplayName(),
                ItemTypeName = item.ItemType.GetDisplayName()

            };
        }

        //public static List<ItemModel> ToCollectionModel(List<Item> items)
        //{
        //    return items.Select(e => ToModel(e)).ToList();
        //}
    }
}
