// Tính điểm trung bình và xếp loại 
Console.WriteLine("Nhap diem mon toan: ");
double math = double.Parse(Console.ReadLine());
while (math < 0 || math > 10)
{
    Console.WriteLine("Diem khong hop le! Nhap lai mon Toan: ");
    math = double.Parse(Console.ReadLine());
}

Console.WriteLine("Nhap diem mon ly: ");
double physicts = double.Parse(Console.ReadLine());
while (physicts < 0 || physicts > 10)
{
    Console.WriteLine("Diem khong hop le! Nhap lai mon ly: ");
    physicts = double.Parse(Console.ReadLine());
}

Console.WriteLine("Nhap diem mon hoa: ");
double chemistry = double.Parse(Console.ReadLine());

while (chemistry < 0 || physicts > 10)
{
    Console.WriteLine("Diem khong hop le! Nhap lai mon hoa: ");
    chemistry = double.Parse(Console.ReadLine());
}

double AVG = (math+physicts+chemistry)/3;

if (AVG >= 8.0)
{
    
    Console.WriteLine($" Dat hoc luc gioi voi {Math.Round(AVG, 2)} điem! ");
}
else if (AVG >= 6.5)
{
    Console.WriteLine($" Dat hoc luc kha voi {Math.Round(AVG, 2)} điem! ");
}
else if (AVG >= 5.0)
{
    Console.WriteLine($" Dat hoc luc trung binh voi {Math.Round(AVG, 2)} điem! ");
}
else 
{
    Console.WriteLine($" Dat hoc luc yeu voi {Math.Round(AVG, 2)} điem! ");
}

// Chuyển đổi tiền tệ và tính phí
Console.WriteLine("Nhap so tien USD: ");
decimal usd = decimal.Parse(Console.ReadLine());
while (usd < 0)
{
    Console.WriteLine("So tien khong hop le. Yeu cau nhap lai:  ");
    usd = decimal.Parse(Console.ReadLine());
}
decimal TyGia = 25300;
decimal PhiChuyenDoi = 0.005m;
decimal vnd = usd * TyGia;
decimal PhiCanChuyenDoiQuaVND = vnd * PhiChuyenDoi;
decimal tong = PhiCanChuyenDoiQuaVND + vnd;
Console.WriteLine($"Voi so tien {usd} se duoc chuyen doi thanh" +
                  $" {vnd}VND va phi chuyen khoan la{PhiCanChuyenDoiQuaVND} VND" +
                  $"nen tong tien phai tra la {tong}VND");
                  
//Tính diện tích và chu vi hình chữ nhật + so sánh

Console.WriteLine("Nhap chieu dai hinh 1: ");
double dai1 = double.Parse(Console.ReadLine());
while (dai1 <= 0)
{
    Console.WriteLine("Chieu dai khong the nho hon 1. Nhap lai chieu dai hinh 1: ");
    dai1 = double.Parse(Console.ReadLine());
}                  
Console.WriteLine("Nhap chieu rong hinh 1: ");
double rong1 = double.Parse(Console.ReadLine());
while (rong1 <= 0)
{
    Console.WriteLine("Chieu rong khong the nho hon 1. Nhap lai chieu rong hinh 1: "); 
    rong1 = double.Parse(Console.ReadLine());
}


Console.WriteLine("Nhap chieu dai hinh 2: ");
double dai2 = double.Parse(Console.ReadLine());
while (dai2 <= 0)
{
    Console.WriteLine("Chieu dai khong the nho hon 1. Nhap lai chieu dai hinh 2: ");
    dai2 = double.Parse(Console.ReadLine());
}                  
Console.WriteLine("Nhap chieu rong hinh 2: ");
double rong2 = double.Parse(Console.ReadLine());
while (rong2 <= 0)
{
    Console.WriteLine("Chieu rong khong the nho hon 1. Nhap lai chieu rong hinh 2: "); 
    rong2 = double.Parse(Console.ReadLine());
}

double ChuVi1 = (dai1 + rong1)*2;
double ChuVi2 = (dai2 + rong2)*2;
double DienTich1 = dai1*rong1;
double DienTich2 = dai2*rong2;

Console.WriteLine($"hinh chu nhat 1 co chieu dai {dai1} va chieu rong {rong1}");
Console.WriteLine("Co chu vi la: "+ ChuVi1);
Console.WriteLine("Co dien tich la: "+ DienTich1);

Console.WriteLine($"hinh chu nhat 2 co chieu dai {dai2} va chieu rong {rong2}");
Console.WriteLine("Co chu vi la: "+ ChuVi2);
Console.WriteLine("Co dien tich la: "+ DienTich2);

if (DienTich1 > DienTich2)
{
    double DienTichChenhLech = DienTich1 - DienTich2;
    Console.WriteLine($"hinh 1 co dien tich lon hon hinh 2 {DienTichChenhLech} met vuong");
}
else
{
    double DienTichChenhLech2 = DienTich2 - DienTich1;
    Console.WriteLine($"hinh 2 co dien tich lon hon hinh 1 {DienTichChenhLech2} met vuong");
}
