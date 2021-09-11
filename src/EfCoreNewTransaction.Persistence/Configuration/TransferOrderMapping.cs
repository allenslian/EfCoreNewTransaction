using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using EfCoreNewTransaction.Domain.Transfer;


namespace EfCoreNewTransaction.Persistence.Configuration
{
    public class TransferOrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable<Order>("transfer_order");
            builder.HasKey(m => m.Id).HasName("pk_transfer_order_id");
            builder.HasIndex(m => m.OrderId, "ix_transfer_order_order_id");

            builder.Property(m => m.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(m => m.OrderId)
                .HasColumnName("order_id")
                .IsRequired();
            builder.Property(m => m.OrderNo)
                .HasColumnName("order_no")
                .HasMaxLength(128)
                .IsRequired();
            builder.Property(m => m.OperationId)
                .HasColumnName("operation")
                .IsRequired(false);
            builder.Property(m => m.Step)
                .HasColumnName("step")
                .HasColumnType("smallint")
                .IsRequired(false);
            builder.Property(m => m.Status)
                .HasColumnName("status")
                .HasColumnType("smallint")
                .IsRequired(false);
            builder.Property(m => m.Payer.Id)
                .HasColumnName("payer_id")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(m => m.Payer.Name)
                .HasColumnName("payer_account_name")
                .HasMaxLength(128)
                .IsRequired();
            builder.Property(m => m.Payer.Number)
                .HasColumnName("payer_account_no")
                .HasMaxLength(128)
                .IsRequired();
            builder.Property(m => m.TotalAmount)
                .HasColumnName("total_amount")
                .HasColumnType("money")
                .IsRequired();
            builder.Property(m => m.BizId)
                .HasColumnName("biz_id")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(m => m.WebHookUrl)
                .HasColumnName("web_hook_url")
                .HasMaxLength(500)
                .IsRequired();
            builder.Property(m => m.IsOnline)
                .HasColumnName("is_online")
                .IsRequired();
            builder.Property(m => m.DateCreated)
                .HasColumnName("date_created")
                .HasColumnType("smalldatetime")
                .IsRequired();
            builder.Property(m => m.CreatedBy)
                .HasColumnName("created_by")
                .HasMaxLength(128)
                .IsRequired();
            builder.Property(m => m.DateModified)
                .HasColumnName("date_modified")
                .HasColumnType("smalldatetime")
                .IsRequired();
            builder.Property(m => m.ModifiedBy)
                .HasColumnName("modified_by")
                .HasMaxLength(128)
                .IsRequired();
            builder.Property(m => m.Version)
                .HasColumnName("version")
                .IsRowVersion()
                .IsRequired();
        }
    }
}