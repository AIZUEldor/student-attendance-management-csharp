#  Student Attendance Management  
### Clean Architecture — C# Console Application

![Demo GIF](./your_gif.gif)

Ushbu loyiha talabalarning ma’lumotlari (**Students**) va davomatlari (**Attendances**) ni boshqarish uchun yaratilgan.  
Loyiha **Clean Architecture** tamoyillari asosida 4 qatlamga bo‘lingan:

- **Domain**
- **Infrastructure**
- **Application**
- **Client (Console UI)**

Konsol orqali foydalanuvchidan ma’lumot olish, ularni saqlash va ro‘yxatda ko‘rsatish imkonini beradi.

---

##  Arxitektura tuzilishi
Project/
│
├── Domain
│ └── Models
│ ├── Student.cs
│ ├── Attendance.cs
│
├── Infrastructure
│ └── Data
│ └── DatabaseContext.cs
│
├── Application
│ └── Services
│ ├── StudentService.cs
│ └── AttendanceService.cs
│
└── Client


---

##  Qisqacha ishlash mantig‘i

### **1) Domain Layer**
Asosiy modeli obyektlar joylashgan:

- `Student`
- `Attendance`

### **2) Infrastructure Layer**
Ma’lumotlar **List<T>** ko‘rinishida vaqtinchalik saqlanadi:

```csharp
public List<Student> Students = new List<Student>();
public List<Attendance> Attendances = new List<Attendance>();

===== MENYU =====
1. Student qo'shish
2. Studentlarni ko'rish
3. Davomat qo'shish
4. Davomatlarni ko'rish
0. Chiqish


git clone https://github.com/<your_username>/<repo_name>.git

Muallif :
Eldor Ro‘ziyev


└── Program.cs

