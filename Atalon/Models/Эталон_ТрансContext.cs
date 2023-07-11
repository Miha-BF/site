using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Atalon.Models
{
    public partial class Эталон_ТрансContext : DbContext
    {
        public Эталон_ТрансContext()
        {
        }

        public Эталон_ТрансContext(DbContextOptions<Эталон_ТрансContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Адрес> Адресs { get; set; }
        public virtual DbSet<Водители> Водителиs { get; set; }
        public virtual DbSet<ВыполнениеРасписания> ВыполнениеРасписанияs { get; set; }
        public virtual DbSet<ВыполненияРейсов> ВыполненияРейсовs { get; set; }
        public virtual DbSet<ДоговорНаМногоразовуюУслугу> ДоговорНаМногоразовуюУслугуs { get; set; }
        public virtual DbSet<ДоговорНаОдиночнуюУслугу> ДоговорНаОдиночнуюУслугуs { get; set; }
        public virtual DbSet<Заказ> Заказs { get; set; }
        public virtual DbSet<ЗакупкаМатериалов> ЗакупкаМатериаловs { get; set; }
        public virtual DbSet<ЗаявкиОПеревозках> ЗаявкиОПеревозкахs { get; set; }
        public virtual DbSet<ЗаявкиОПоставках> ЗаявкиОПоставкахs { get; set; }
        public virtual DbSet<КлиентОрганизация> КлиентОрганизацияs { get; set; }
        public virtual DbSet<Материал> Материалs { get; set; }
        public virtual DbSet<Машины> Машиныs { get; set; }
        public virtual DbSet<ОплатаВодителям> ОплатаВодителямs { get; set; }
        public virtual DbSet<Организации> Организацииs { get; set; }
        public virtual DbSet<Поставщики> Поставщикиs { get; set; }
        public virtual DbSet<РасписаниеВодителей> РасписаниеВодителейs { get; set; }
        public virtual DbSet<Регистрация> Регистрацияs { get; set; }
        public virtual DbSet<ТипыМашин> ТипыМашинs { get; set; }
        public virtual DbSet<ТипыУслуг> ТипыУслугs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-66EIDQ6\\MSSQLSERVER01;Initial Catalog=Эталон_Транс;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Material");

                entity.Property(e => e.CostOfMass)
                    .HasMaxLength(10)
                    .HasColumnName("Cost of mass")
                    .IsFixedLength(true);

                entity.Property(e => e.CostOfVolume)
                    .HasMaxLength(10)
                    .HasColumnName("Cost of volume")
                    .IsFixedLength(true);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(70)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Адрес>(entity =>
            {
                entity.HasKey(e => e.IdАдреса);

                entity.ToTable("Адрес");

                entity.Property(e => e.IdАдреса)
                    .ValueGeneratedNever()
                    .HasColumnName("id адреса");

                entity.Property(e => e.Город)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Дом)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Область)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Описание)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Район)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Улица)
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Водители>(entity =>
            {
                entity.HasKey(e => e.IdВодителя);

                entity.ToTable("Водители");

                entity.Property(e => e.IdВодителя)
                    .ValueGeneratedNever()
                    .HasColumnName("id водителя");

                entity.Property(e => e.Статус)
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.Фамилия)
                    .HasMaxLength(100)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ВыполнениеРасписания>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Выполнение расписания");

                entity.Property(e => e.IdРасписания).HasColumnName("id расписания");

                entity.Property(e => e.Дата).HasColumnType("date");

                entity.Property(e => e.КоличествоРейсов)
                    .HasMaxLength(10)
                    .HasColumnName("Количество рейсов")
                    .IsFixedLength(true);

                entity.Property(e => e.ОписаниеБылНеБыл)
                    .HasMaxLength(100)
                    .HasColumnName("Описание (был, не был)")
                    .IsFixedLength(true);

                entity.Property(e => e.ФактическоеВремяНачалаРаботы).HasColumnName("Фактическое время начала работы");

                entity.Property(e => e.ФактическоеВремяОкончанияРаботы).HasColumnName("Фактическое время окончания работы");

                entity.HasOne(d => d.IdРасписанияNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdРасписания)
                    .HasConstraintName("FK_Выполнение расписания_Расписание водителей");
            });

            modelBuilder.Entity<ВыполненияРейсов>(entity =>
            {
                entity.HasKey(e => e.IdРейса);

                entity.ToTable("Выполнения рейсов");

                entity.Property(e => e.IdРейса)
                    .ValueGeneratedNever()
                    .HasColumnName("id рейса");

                entity.Property(e => e.IdВодителя).HasColumnName("id водителя");

                entity.Property(e => e.IdМашины).HasColumnName("id машины");

                entity.Property(e => e.IdОрганизации).HasColumnName("id организации");

                entity.Property(e => e.НомерДоговора).HasColumnName("Номер договора");

                entity.Property(e => e.ФактическаяДатаНачалаРаботы)
                    .HasColumnType("date")
                    .HasColumnName("Фактическая дата начала работы");

                entity.Property(e => e.ФактическаяДатаОкончанияРаботы)
                    .HasColumnType("date")
                    .HasColumnName("Фактическая дата окончания работы");

                entity.HasOne(d => d.IdВодителяNavigation)
                    .WithMany(p => p.ВыполненияРейсовs)
                    .HasForeignKey(d => d.IdВодителя)
                    .HasConstraintName("FK_Выполнения рейсов_Водители");

                entity.HasOne(d => d.IdМашиныNavigation)
                    .WithMany(p => p.ВыполненияРейсовs)
                    .HasForeignKey(d => d.IdМашины)
                    .HasConstraintName("FK_Выполнения рейсов_Машины");

                entity.HasOne(d => d.IdОрганизацииNavigation)
                    .WithMany(p => p.ВыполненияРейсовs)
                    .HasForeignKey(d => d.IdОрганизации)
                    .HasConstraintName("FK_Выполнения рейсов_Организации");

                entity.HasOne(d => d.НомерДоговораNavigation)
                    .WithMany(p => p.ВыполненияРейсовs)
                    .HasForeignKey(d => d.НомерДоговора)
                    .HasConstraintName("FK_Выполнения рейсов_Рейсы");
            });

            modelBuilder.Entity<ДоговорНаМногоразовуюУслугу>(entity =>
            {
                entity.HasKey(e => e.НомерДоговора)
                    .HasName("PK_Договор на многоразовую поставку");

                entity.ToTable("Договор на многоразовую услугу");

                entity.Property(e => e.НомерДоговора)
                    .ValueGeneratedNever()
                    .HasColumnName("Номер договора");

                entity.Property(e => e.IdАдресаКуда).HasColumnName("id адреса куда");

                entity.Property(e => e.IdАдресаОткуда).HasColumnName("id адреса откуда");

                entity.Property(e => e.IdОрганизации).HasColumnName("id организации");

                entity.Property(e => e.IdТипаУслуги).HasColumnName("id типа услуги");

                entity.Property(e => e.ДатаВнесенияВБдИзТаблицыЗаявок)
                    .HasColumnType("date")
                    .HasColumnName("Дата внесения в БД из таблицы заявок");

                entity.Property(e => e.ДатаНачалаРаботы)
                    .HasColumnType("date")
                    .HasColumnName("Дата начала работы");

                entity.Property(e => e.ДатаОкончанияРаботы)
                    .HasColumnType("date")
                    .HasColumnName("Дата окончания работы");

                entity.Property(e => e.НомерДопСоглашения)
                    .HasMaxLength(10)
                    .HasColumnName("Номер доп соглашения")
                    .IsFixedLength(true);

                entity.Property(e => e.ПризнакДопСоглашения)
                    .HasMaxLength(10)
                    .HasColumnName("Признак доп соглашения")
                    .IsFixedLength(true);

                entity.Property(e => e.Сумма)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.ТипОплаты)
                    .HasMaxLength(100)
                    .HasColumnName("Тип оплаты")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdАдресаКудаNavigation)
                    .WithMany(p => p.ДоговорНаМногоразовуюУслугуIdАдресаКудаNavigations)
                    .HasForeignKey(d => d.IdАдресаКуда)
                    .HasConstraintName("FK_Договор на многоразовую поставку_Адрес1");

                entity.HasOne(d => d.IdАдресаОткудаNavigation)
                    .WithMany(p => p.ДоговорНаМногоразовуюУслугуIdАдресаОткудаNavigations)
                    .HasForeignKey(d => d.IdАдресаОткуда)
                    .HasConstraintName("FK_Договор на многоразовую поставку_Адрес");

                entity.HasOne(d => d.IdОрганизацииNavigation)
                    .WithMany(p => p.ДоговорНаМногоразовуюУслугуs)
                    .HasForeignKey(d => d.IdОрганизации)
                    .HasConstraintName("FK_Договор на многоразовую поставку_Организации");

                entity.HasOne(d => d.IdТипаУслугиNavigation)
                    .WithMany(p => p.ДоговорНаМногоразовуюУслугуs)
                    .HasForeignKey(d => d.IdТипаУслуги)
                    .HasConstraintName("FK_Договор на многоразовую услугу_Типы услуг");
            });

            modelBuilder.Entity<ДоговорНаОдиночнуюУслугу>(entity =>
            {
                entity.HasKey(e => e.НомерДоговора)
                    .HasName("PK_Рейсы");

                entity.ToTable("Договор на одиночную услугу");

                entity.Property(e => e.НомерДоговора)
                    .ValueGeneratedNever()
                    .HasColumnName("Номер договора");

                entity.Property(e => e.IdАдресаКуда).HasColumnName("id адреса куда");

                entity.Property(e => e.IdАдресаОткуда).HasColumnName("id адреса откуда");

                entity.Property(e => e.IdОрганизации).HasColumnName("id организации");

                entity.Property(e => e.IdТипаУслуги).HasColumnName("id типа услуги");

                entity.Property(e => e.ДатаВнесенияВБдИзТаблицыЗаявок)
                    .HasColumnType("date")
                    .HasColumnName("Дата внесения в БД из таблицы заявок");

                entity.Property(e => e.ДатаНачалаРаботы)
                    .HasColumnType("date")
                    .HasColumnName("Дата начала работы");

                entity.Property(e => e.ДатаОкончанияРаботы)
                    .HasColumnType("date")
                    .HasColumnName("Дата окончания работы");

                entity.Property(e => e.НомерДопСоглашения)
                    .HasMaxLength(10)
                    .HasColumnName("Номер доп соглашения")
                    .IsFixedLength(true);

                entity.Property(e => e.ПризнакДопСоглашения)
                    .HasMaxLength(10)
                    .HasColumnName("Признак доп соглашения")
                    .IsFixedLength(true);

                entity.Property(e => e.Сумма)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.ТипОплаты)
                    .HasMaxLength(100)
                    .HasColumnName("Тип оплаты")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdАдресаКудаNavigation)
                    .WithMany(p => p.ДоговорНаОдиночнуюУслугуIdАдресаКудаNavigations)
                    .HasForeignKey(d => d.IdАдресаКуда)
                    .HasConstraintName("FK_Рейсы_Адрес1");

                entity.HasOne(d => d.IdАдресаОткудаNavigation)
                    .WithMany(p => p.ДоговорНаОдиночнуюУслугуIdАдресаОткудаNavigations)
                    .HasForeignKey(d => d.IdАдресаОткуда)
                    .HasConstraintName("FK_Рейсы_Адрес");

                entity.HasOne(d => d.IdОрганизацииNavigation)
                    .WithMany(p => p.ДоговорНаОдиночнуюУслугуs)
                    .HasForeignKey(d => d.IdОрганизации)
                    .HasConstraintName("FK_Рейсы_Организации");

                entity.HasOne(d => d.IdТипаУслугиNavigation)
                    .WithMany(p => p.ДоговорНаОдиночнуюУслугуs)
                    .HasForeignKey(d => d.IdТипаУслуги)
                    .HasConstraintName("FK_Договор на одиночную услугу_Типы услуг");
            });

            modelBuilder.Entity<Заказ>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Заказ");

                entity.Property(e => e.IdМатериала).HasColumnName("id материала");

                entity.Property(e => e.КоличествоКубов)
                    .HasMaxLength(50)
                    .HasColumnName("Количество кубов")
                    .IsFixedLength(true);

                entity.Property(e => e.КоличествоТонн)
                    .HasMaxLength(50)
                    .HasColumnName("Количество тонн")
                    .IsFixedLength(true);

                entity.Property(e => e.НомерДоговора).HasColumnName("Номер договора");

                entity.HasOne(d => d.IdМатериалаNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdМатериала)
                    .HasConstraintName("FK_Заказ_Материал");

                entity.HasOne(d => d.IdМатериала1)
                    .WithMany()
                    .HasForeignKey(d => d.IdМатериала)
                    .HasConstraintName("FK_Заказ_Договор на одиночную поставку");

                entity.HasOne(d => d.НомерДоговораNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.НомерДоговора)
                    .HasConstraintName("FK_Заказ_Договор на многоразовую поставку");
            });

            modelBuilder.Entity<ЗакупкаМатериалов>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Закупка материалов");

                entity.Property(e => e.IdМатериала).HasColumnName("id материала");

                entity.Property(e => e.IdПоставщика).HasColumnName("id поставщика");

                entity.Property(e => e.ЕдиницыИзмерения)
                    .HasMaxLength(10)
                    .HasColumnName("Единицы измерения")
                    .IsFixedLength(true);

                entity.Property(e => e.Количество)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Сумма)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdМатериалаNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdМатериала)
                    .HasConstraintName("FK_Закупка материалов_Материал");

                entity.HasOne(d => d.IdПоставщикаNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdПоставщика)
                    .HasConstraintName("FK_Закупка материалов_Поставщики");
            });

            modelBuilder.Entity<ЗаявкиОПеревозках>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("Заявки о перевозках");

                entity.Property(e => e.IdМатериала).HasColumnName("id материала");

                entity.Property(e => e.IdОрганизации).HasColumnName("id организации");

                entity.Property(e => e.IdТипаУслуги).HasColumnName("id типа услуги");

                entity.Property(e => e.Email)
                   .HasMaxLength(100)
                   .HasColumnName("Email")
                   .IsFixedLength(true);

                entity.Property(e => e.АдресКуда)
                    .HasMaxLength(210)
                    .HasColumnName("Адрес куда")
                    .IsFixedLength(true);

                entity.Property(e => e.АдресОткуда)
                    .HasMaxLength(210)
                    .HasColumnName("Адрес откуда")
                    .IsFixedLength(true);

                entity.Property(e => e.ДатаВнесенияВБазу)
                    .HasColumnType("date")
                    .HasColumnName("Дата внесения в базу");

                entity.Property(e => e.ДатаОбработкиЗаявки)
                    .HasColumnType("date")
                    .HasColumnName("Дата обработки заявки");

                entity.Property(e => e.Дэдлайн).HasColumnType("date");

                entity.Property(e => e.НомерДоговора).HasColumnName("Номер договора");

                entity.Property(e => e.Фио)
                    .HasMaxLength(100)
                    .HasColumnName("ФИО")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdОрганизацииNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdОрганизации)
                    .HasConstraintName("FK_Заявки о перевозках_Организации");

                entity.HasOne(d => d.IdТипаУслугиNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdТипаУслуги)
                    .HasConstraintName("FK_Заявки о перевозках_Типы услуг");

                entity.HasOne(d => d.НомерДоговораNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.НомерДоговора)
                    .HasConstraintName("FK_Заявки о перевозках_Договор на одиночную поставку");
            });

            modelBuilder.Entity<ЗаявкиОПоставках>(entity =>
            {
                
                entity.HasKey(e => e.Id);

                entity.ToTable("Заявки о поставках");

                entity.Property(e => e.IdМатериала).HasColumnName("id материала");

                entity.Property(e => e.IdОрганизации).HasColumnName("id организации");

                entity.Property(e => e.IdТипаУслуги).HasColumnName("id типа услуги");

                entity.Property(e => e.Email)
                   .HasMaxLength(100)
                   .HasColumnName("Email")
                   .IsFixedLength(true);

                entity.Property(e => e.АдресКуда)
                    .HasMaxLength(210)
                    .HasColumnName("Адрес куда")
                    .IsFixedLength(true);     

                entity.Property(e => e.АдресОткуда)
                    .HasMaxLength(210)
                    .HasColumnName("Адрес откуда")
                    .IsFixedLength(true);

                entity.Property(e => e.ДатаВнесенияВБазу)
                    .HasColumnType("date")
                    .HasColumnName("Дата внесения в базу");

                entity.Property(e => e.ДатаОбработкиЗаявки)
                    .HasColumnType("date")
                    .HasColumnName("Дата обработки заявки");

                entity.Property(e => e.Дэдлайн).HasColumnType("date");

                entity.Property(e => e.НомерДоговора).HasColumnName("Номер договора");

                entity.Property(e => e.Фио)
                    .HasMaxLength(100)
                    .HasColumnName("ФИО")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdОрганизацииNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdОрганизации)
                    .HasConstraintName("FK_Заявки о поставках_Организации");

                entity.HasOne(d => d.IdТипаУслугиNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdТипаУслуги)
                    .HasConstraintName("FK_Заявки о поставках_Типы услуг");

                entity.HasOne(d => d.НомерДоговораNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.НомерДоговора)
                    .HasConstraintName("FK_Заявки о поставках_Договор на одиночную поставку");
            });

            modelBuilder.Entity<КлиентОрганизация>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Клиент-Организация");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.IdКлиента)
                    .HasMaxLength(10)
                    .HasColumnName("id клиента")
                    .IsFixedLength(true);

                entity.Property(e => e.IdОрганизации).HasColumnName("id организации");

                entity.Property(e => e.Фио)
                    .HasMaxLength(150)
                    .HasColumnName("ФИО")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdКлиентаNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdКлиента)
                    .HasConstraintName("FK_Клиент-Организация_Регистрация");

                entity.HasOne(d => d.IdОрганизацииNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdОрганизации)
                    .HasConstraintName("FK_Клиент-Организация_Организации");
            });

            modelBuilder.Entity<Материал>(entity =>
            {
                entity.HasKey(e => e.IdМатериала);

                entity.ToTable("Материал");

                entity.Property(e => e.IdМатериала)
                    .ValueGeneratedNever()
                    .HasColumnName("id материала");

                entity.Property(e => e.Название)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.ЦенаЗаКуб)
                    .HasMaxLength(10)
                    .HasColumnName("Цена за куб")
                    .IsFixedLength(true);

                entity.Property(e => e.ЦенаЗаТонну)
                    .HasMaxLength(10)
                    .HasColumnName("Цена за тонну")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Машины>(entity =>
            {
                entity.HasKey(e => e.IdМашины);

                entity.ToTable("Машины");

                entity.Property(e => e.IdМашины)
                    .ValueGeneratedNever()
                    .HasColumnName("id машины");

                entity.Property(e => e.IdТипа)
                    .HasMaxLength(10)
                    .HasColumnName("id типа")
                    .IsFixedLength(true);

                entity.Property(e => e.НомерМашины)
                    .HasMaxLength(10)
                    .HasColumnName("номер машины")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdТипаNavigation)
                    .WithMany(p => p.Машиныs)
                    .HasForeignKey(d => d.IdТипа)
                    .HasConstraintName("FK_Машины_Типы Машин");
            });

            modelBuilder.Entity<ОплатаВодителям>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Оплата водителям");

                entity.Property(e => e.IdВодителя).HasColumnName("id водителя");

                entity.Property(e => e.IdРейса).HasColumnName("id рейса");

                entity.Property(e => e.Оплата)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdВодителяNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdВодителя)
                    .HasConstraintName("FK_Оплата водителям_Водители");

                entity.HasOne(d => d.IdРейсаNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdРейса)
                    .HasConstraintName("FK_Оплата водителям_Выполнения рейсов");
            });

            modelBuilder.Entity<Организации>(entity =>
            {
                entity.HasKey(e => e.IdОрганизации);

                entity.ToTable("Организации");

                entity.Property(e => e.IdОрганизации)
                    .ValueGeneratedNever()
                    .HasColumnName("id организации");

                entity.Property(e => e.Инн)
                    .HasMaxLength(20)
                    .HasColumnName("ИНН")
                    .IsFixedLength(true);

                entity.Property(e => e.Название)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.ТелефонДляСвязи)
                    .HasMaxLength(20)
                    .HasColumnName("Телефон для связи")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Поставщики>(entity =>
            {
                entity.HasKey(e => e.IdПоставщика);

                entity.ToTable("Поставщики");

                entity.Property(e => e.IdПоставщика)
                    .ValueGeneratedNever()
                    .HasColumnName("id поставщика");

                entity.Property(e => e.Название)
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<РасписаниеВодителей>(entity =>
            {
                entity.HasKey(e => e.IdРасписания);

                entity.ToTable("Расписание водителей");

                entity.Property(e => e.IdРасписания)
                    .ValueGeneratedNever()
                    .HasColumnName("id расписания");

                entity.Property(e => e.IdВодителя).HasColumnName("id водителя");

                entity.Property(e => e.ВремяНачала).HasColumnName("Время начала");

                entity.Property(e => e.ВремяОкончания).HasColumnName("Время окончания");

                entity.Property(e => e.ДеньНедели)
                    .HasMaxLength(10)
                    .HasColumnName("День недели")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdВодителяNavigation)
                    .WithMany(p => p.РасписаниеВодителейs)
                    .HasForeignKey(d => d.IdВодителя)
                    .HasConstraintName("FK_Расписание водителей_Водители");
            });

            modelBuilder.Entity<Регистрация>(entity =>
            {
                entity.HasKey(e => e.IdКлиента);

                entity.ToTable("Регистрация");

                entity.Property(e => e.IdКлиента)
                    .HasMaxLength(10)
                    .HasColumnName("id клиента")
                    .IsFixedLength(true);

                entity.Property(e => e.Логин)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Пароль)
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ТипыМашин>(entity =>
            {
                entity.HasKey(e => e.IdТипа);

                entity.ToTable("Типы Машин");

                entity.Property(e => e.IdТипа)
                    .HasMaxLength(10)
                    .HasColumnName("id типа")
                    .IsFixedLength(true);

                entity.Property(e => e.ВместимостьВКубах)
                    .HasMaxLength(10)
                    .HasColumnName("Вместимость (в кубах)")
                    .IsFixedLength(true);

                entity.Property(e => e.ВместимостьВТоннах)
                    .HasMaxLength(10)
                    .HasColumnName("Вместимость (в тоннах)")
                    .IsFixedLength(true);

                entity.Property(e => e.Название)
                    .HasMaxLength(60)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ТипыУслуг>(entity =>
            {
                entity.HasKey(e => e.IdТипаУслуги);

                entity.ToTable("Типы услуг");

                entity.Property(e => e.IdТипаУслуги)
                    .ValueGeneratedNever()
                    .HasColumnName("id типа услуги");

                entity.Property(e => e.Название)
                    .HasMaxLength(100)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
