using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseManagement
{
    public enum RoleSystem
    {
        CreateUser = 600,   //Tạo người dùng mới
        DeleteUser = 601,   //Xóa người dùng
        UpdateUser = 602,   //Cập nhật người dùng
        CreateGroup = 603,  //Tạo mới nhóm người dùng mới
        DeleteGroup = 604,  //Xóa nhóm người dùng
        UpdateGroup = 605,  //Cập nhật nhóm người dùng
        Permission = 606,   //Phân quyền
        Management = 607,   //Xem quản trị
    };
    #region Bán hàng
    // Bán hàng
    public enum Sales
    {
        Cashier = 100,   //Bán hàng
    };
    // Khách hàng
    public enum Customers
    {
        AddNew = 700,   //Thêm mới
        Edit = 701,   //Cập nhật
        Delete = 702,   //Xoá
        Management = 703,   //Theo dõi
        DebtManagement = 704,   //Công nợ khách hàng
    };
    #endregion Hàng hoá
    // Hàng hoá
    public enum Products
    {
        AddNew = 300,   //Thêm mới
        Edit = 302,   //Cập nhật
        Delete = 303,   //Xoá
        Management = 301,   //Theo dõi
    };
    // Nhóm hàng hoá
    public enum Categories
    {
        AddNew = 200,   //Thêm mới
        Edit = 202,   //Cập nhật
        Delete = 203,   //Xoá
        Management = 201,   //Theo dõi
    };
    #region Xuất nhập tồn
    public enum Inventories
    {
        Management = 400,   //Theo dõi
    };
    // Nhập kho
    public enum PurchaseOrders
    {
        AddNew = 500,   //Thêm mới
        Edit = 502,   //Cập nhật
        Delete = 503,   //Xoá
        Management = 501,   //Theo dõi
    };
    // Nhà cung cấp
    public enum Suppliers
    {
        AddNew = 800,   //Thêm mới
        Edit = 801,   //Cập nhật
        Delete = 802,   //Xoá
        Management = 803,   //Theo dõi
    };
    // Kho
    public enum WareHouses
    {
        AddNew = 900,   //Thêm mới
        Edit = 901,   //Cập nhật
        Delete = 902,   //Xoá
        Management = 903,   //Theo dõi
    };
    #endregion
    #region Sổ quỹ
    // Sổ quỹ
    public enum CashFlows
    {
        Management = 101,   //Theo dõi
        Delete = 103,   //Xoá hoá đơn
    };
    // Phiếu chi
    public enum Payments
    {
        AddNew = 1000,   //Thêm mới
        Edit = 1001,   //Cập nhật
        Delete = 1002,   //Xoá
        Management = 1003,   //Theo dõi
    };
    // Loại chi
    public enum PaymentTypes
    {
        AddNew = 1100,   //Thêm mới
        Edit = 1101,   //Cập nhật
        Delete = 1102,   //Xoá
        Management = 1103,   //Theo dõi
    };
    // Phiếu thu
    public enum Receiptes
    {
        AddNew = 1200,   //Thêm mới
        Edit = 1201,   //Cập nhật
        Delete = 1202,   //Xoá
        Management = 1203,   //Theo dõi
    };
    // Loại thu
    public enum ReceiptsTypes
    {
        AddNew = 1300,   //Thêm mới
        Edit = 1301,   //Cập nhật
        Delete = 1302,   //Xoá
        Management = 1303,   //Theo dõi
    };
    #endregion
}
