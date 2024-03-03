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
}
