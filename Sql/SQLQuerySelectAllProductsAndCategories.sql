use Dev

select Products.Name, Categories.Name from Products left join ProductsCategories on Products.Id = ProductsCategories.ProductsId left join Categories on ProductsCategories.CategoriesId = Categories.Id
