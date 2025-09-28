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
                Price = itemInput.Price,
                StockQuantity = itemInput.StockQuantity,
                Status = itemInput.Status,

            };

        }

        public static ItemModel ToModel(this Item item)
        {
            return new ItemModel { 
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                StockQuantity = item.StockQuantity,
                Status = item.Status,
                StatusName = item.Status.GetDisplayName(),
                ItemType = item.ItemType,
                ItemTypeName = item.ItemType.GetDisplayName()

            };
        }

        //public static List<ItemModel> ToCollectionModel(List<Item> items)
        //{
        //    return items.Select(e => ToModel(e)).ToList();
        //}
    }
}
