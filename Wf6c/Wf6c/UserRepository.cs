using CongAn.Data;
using CongAn.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CongAn.Helper
{
    public static class UserRepository
    {
        public static List<User> GetList()
        {
            var reader = AppDbContext.ExcuteSelect(@"SELECT 
                    STT,
                    LoaiDt,
                    HoVaTen,
                    NamSinhText, 
                    NoiSinh, 
                    QueQuan, 
                    NoiDktt, 
                    NoiOHienTai, 
                    TrinhDoHocVan, 
                    NgheNghiep, 
                    VoChong, 
                    Cha, 
                    Me, 
                    Con, 
                    AnhChiEm, 
                    TienAn, 
                    MoiQHXH, 
                    HinhAnhDt, 
                    Cmnd, 
                    NgayCap, 
                    SoHoKhau, 
                    DacDiemNhanDang, 
                    GhiChu
                    FROM Users");

            var data = new List<User>();
            while (reader.Read()) // Read() returns true if there is still a result line to read
            {
                var i = 0;
                data.Add(new User
                {
                    STT = reader.GetInt16(i),
                    LoaiDt = reader.GetString(++i),
                    HoVaTen = reader.GetString(++i),
                    NamSinhText = reader.GetString(++i),
                    NoiSinh = reader.GetString(++i),
                    QueQuan = reader.GetString(++i),
                    NoiDktt = reader.GetString(++i),
                    NoiOHienTai = reader.GetString(++i),
                    TrinhDoHocVan = reader.GetString(++i),
                    NgheNghiep = reader.GetString(++i),
                    VoChong = reader.GetString(++i),
                    Cha = reader.GetString(++i),
                    Me = reader.GetString(++i),
                    Con = reader.GetString(++i),
                    AnhChiEm = reader.GetString(++i),
                    TienAn = reader.GetString(++i),
                    MoiQHXH = reader.GetString(++i),
                    HinhAnhDt = reader.GetString(++i),
                    Cmnd = reader.GetString(++i),
                    NgayCap = reader.GetString(++i),
                    SoHoKhau = reader.GetString(++i),
                    DacDiemNhanDang = reader.GetString(++i),
                    GhiChu = reader.GetString(++i)
                });
            }
            return data;
        }
        
        public static object AddNew(User user)
        {
            var reader = AppDbContext.ExcuteQuery($@"Insert into Users(
                    LoaiDt,
                    HoVaTen,
                    NamSinhText,
                    NoiSinh,
                    QueQuan,
                    NoiDktt,
                    NoiOHienTai,
                    TrinhDoHocVan,
                    NgheNghiep,
                    VoChong,
                    Cha,
                    Me,
                    Con,
                    AnhChiEm,
                    TienAn,
                    MoiQHXH,
                    HinhAnhDt,
                    Cmnd,
                    NgayCap,
                    SoHoKhau,
                    DacDiemNhanDang,
                    GhiChu) values
                    (
                    '{user.LoaiDt}',
                    '{user.HoVaTen}',
                    '{user.NamSinhText}',
                    '{user.NoiSinh}',
                    '{user.QueQuan}',
                    '{user.NoiDktt}',
                    '{user.NoiOHienTai}',
                    '{user.TrinhDoHocVan}',
                    '{user.NgheNghiep}',
                    '{user.VoChong}',
                    '{user.Cha}',
                    '{user.Me}',
                    '{user.Con}',
                    '{user.AnhChiEm}',
                    '{user.TienAn}',
                    '{user.MoiQHXH}',
                    '{user.HinhAnhDt}',
                    '{user.Cmnd}',
                    '{user.NgayCap}',
                    '{user.SoHoKhau}',
                    '{user.DacDiemNhanDang}',
                    '{user.GhiChu}'
                    )");

            return reader;
        }
    }
}
