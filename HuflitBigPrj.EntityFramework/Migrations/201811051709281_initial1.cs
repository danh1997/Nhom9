namespace HuflitBigPrj.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CheckStocks",
                c => new
                    {
                        CheckNo = c.Int(nullable: false, identity: true),
                        CheckDate = c.DateTime(nullable: false),
                        Description = c.String(maxLength: 200),
                        StockNo = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        Id = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_CheckStock_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.CheckNo);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        StockNo = c.Int(nullable: false, identity: true),
                        StockName = c.String(maxLength: 50),
                        Address = c.String(maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        Id = c.Int(nullable: false),
                        CheckStock_CheckNo = c.Int(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Stock_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.StockNo)
                .ForeignKey("dbo.CheckStocks", t => t.CheckStock_CheckNo)
                .Index(t => t.CheckStock_CheckNo);
            
            CreateTable(
                "dbo.StockDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InvtID = c.Int(nullable: false),
                        StockNo = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_StockDetail_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Inventories", t => t.InvtID, cascadeDelete: true)
                .ForeignKey("dbo.Stocks", t => t.StockNo, cascadeDelete: true)
                .Index(t => t.InvtID)
                .Index(t => t.StockNo);
            
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        InvtID = c.Int(nullable: false, identity: true),
                        InvtName = c.String(maxLength: 50),
                        QtyStock = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        Id = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Inventory_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.InvtID);
            
            CreateTable(
                "dbo.SalesOrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Qty = c.Int(nullable: false),
                        SalesPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TaxAmt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAmtCust = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderNo = c.Int(nullable: false),
                        InvtID = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_SalesOrderDetail_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Inventories", t => t.InvtID, cascadeDelete: true)
                .ForeignKey("dbo.SalesOrders", t => t.OrderNo, cascadeDelete: true)
                .Index(t => t.OrderNo)
                .Index(t => t.InvtID);
            
            CreateTable(
                "dbo.SalesOrders",
                c => new
                    {
                        OrderNo = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        ReDate = c.DateTime(nullable: false),
                        SumTaxAmt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAmt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SumPayment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CustID = c.Int(nullable: false),
                        InvoiceType = c.String(nullable: false, maxLength: 2),
                        UserID = c.Long(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        Id = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_SalesOrder_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.OrderNo)
                .ForeignKey("dbo.Customers", t => t.CustID, cascadeDelete: true)
                .ForeignKey("dbo.InvoiceTypes", t => t.InvoiceType, cascadeDelete: true)
                .ForeignKey("dbo.AbpUsers", t => t.UserID, cascadeDelete: true)
                .Index(t => t.CustID)
                .Index(t => t.InvoiceType)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustID = c.Int(nullable: false, identity: true),
                        CustName = c.String(maxLength: 50),
                        Address = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 20),
                        Email = c.String(maxLength: 50),
                        Status = c.String(maxLength: 2),
                    })
                .PrimaryKey(t => t.CustID);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentID = c.Int(nullable: false, identity: true),
                        PaymentNo = c.String(maxLength: 20),
                        PaymentDate = c.DateTime(nullable: false),
                        PaymentAmt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CustID = c.Int(nullable: false),
                        UserID = c.Long(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        Id = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Payment_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.PaymentID)
                .ForeignKey("dbo.Customers", t => t.CustID, cascadeDelete: true)
                .ForeignKey("dbo.AbpUsers", t => t.UserID, cascadeDelete: true)
                .Index(t => t.CustID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.InvoiceTypes",
                c => new
                    {
                        InvoiceTypeID = c.String(nullable: false, maxLength: 2),
                        TypeName = c.String(maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        Id = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_InvoiceType_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.InvoiceTypeID);
            
            CreateTable(
                "dbo.StockTransDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransID = c.Int(nullable: false),
                        Qty = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        InvtID = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_StockTransDetail_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Inventories", t => t.InvtID, cascadeDelete: true)
                .ForeignKey("dbo.StockTransfers", t => t.TransID, cascadeDelete: true)
                .Index(t => t.TransID)
                .Index(t => t.InvtID);
            
            CreateTable(
                "dbo.StockTransfers",
                c => new
                    {
                        TransID = c.Int(nullable: false, identity: true),
                        TransDate = c.Int(nullable: false),
                        TotalAmt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FromStockID = c.Int(),
                        ToStockID = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        Id = c.Int(nullable: false),
                        Stock_StockNo = c.Int(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_StockTransfer_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.TransID)
                .ForeignKey("dbo.Stocks", t => t.FromStockID)
                .ForeignKey("dbo.Stocks", t => t.ToStockID)
                .ForeignKey("dbo.Stocks", t => t.Stock_StockNo)
                .Index(t => t.FromStockID)
                .Index(t => t.ToStockID)
                .Index(t => t.Stock_StockNo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "CheckStock_CheckNo", "dbo.CheckStocks");
            DropForeignKey("dbo.StockTransfers", "Stock_StockNo", "dbo.Stocks");
            DropForeignKey("dbo.StockDetails", "StockNo", "dbo.Stocks");
            DropForeignKey("dbo.StockDetails", "InvtID", "dbo.Inventories");
            DropForeignKey("dbo.StockTransDetails", "TransID", "dbo.StockTransfers");
            DropForeignKey("dbo.StockTransfers", "ToStockID", "dbo.Stocks");
            DropForeignKey("dbo.StockTransfers", "FromStockID", "dbo.Stocks");
            DropForeignKey("dbo.StockTransDetails", "InvtID", "dbo.Inventories");
            DropForeignKey("dbo.SalesOrderDetails", "OrderNo", "dbo.SalesOrders");
            DropForeignKey("dbo.SalesOrders", "UserID", "dbo.AbpUsers");
            DropForeignKey("dbo.SalesOrders", "InvoiceType", "dbo.InvoiceTypes");
            DropForeignKey("dbo.SalesOrders", "CustID", "dbo.Customers");
            DropForeignKey("dbo.Payments", "UserID", "dbo.AbpUsers");
            DropForeignKey("dbo.Payments", "CustID", "dbo.Customers");
            DropForeignKey("dbo.SalesOrderDetails", "InvtID", "dbo.Inventories");
            DropIndex("dbo.StockTransfers", new[] { "Stock_StockNo" });
            DropIndex("dbo.StockTransfers", new[] { "ToStockID" });
            DropIndex("dbo.StockTransfers", new[] { "FromStockID" });
            DropIndex("dbo.StockTransDetails", new[] { "InvtID" });
            DropIndex("dbo.StockTransDetails", new[] { "TransID" });
            DropIndex("dbo.Payments", new[] { "UserID" });
            DropIndex("dbo.Payments", new[] { "CustID" });
            DropIndex("dbo.SalesOrders", new[] { "UserID" });
            DropIndex("dbo.SalesOrders", new[] { "InvoiceType" });
            DropIndex("dbo.SalesOrders", new[] { "CustID" });
            DropIndex("dbo.SalesOrderDetails", new[] { "InvtID" });
            DropIndex("dbo.SalesOrderDetails", new[] { "OrderNo" });
            DropIndex("dbo.StockDetails", new[] { "StockNo" });
            DropIndex("dbo.StockDetails", new[] { "InvtID" });
            DropIndex("dbo.Stocks", new[] { "CheckStock_CheckNo" });
            DropTable("dbo.StockTransfers",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_StockTransfer_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.StockTransDetails",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_StockTransDetail_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.InvoiceTypes",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_InvoiceType_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.Payments",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Payment_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.Customers");
            DropTable("dbo.SalesOrders",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_SalesOrder_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.SalesOrderDetails",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_SalesOrderDetail_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.Inventories",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Inventory_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.StockDetails",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_StockDetail_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.Stocks",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Stock_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.CheckStocks",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_CheckStock_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
