using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using EfCoreNewTransaction.Domain.Transfer;

namespace EfCoreNewTransaction.Persistence.Configuration
{
    /// <summary>
    /// Transfer order detail table
    /// </summary>
    public class TransferOrderDetailMapping : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("transfer_order_detail");
            builder.HasKey(m => m.Id).HasName("pk_transfer_order_detail_id");
            builder.HasIndex(m => m.OrderId, "ix_transfer_order_detail_order_id");

            builder.Property(m => m.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(m => m.OrderId)
                .HasColumnName("order_id")
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
            builder.Property(m => m.StatusDescription)
                .HasColumnName("status_description")
                .HasMaxLength(500)
                .IsRequired();
            builder.Property(m => m.Notes)
                .HasColumnName("notes")
                .HasMaxLength(500)
                .IsRequired();
            builder.OwnsOne(m => m.Payee,
                x =>
                {
                    x.Property(m => m.Id)
                        .HasColumnName("payee_id")
                        .HasMaxLength(50)
                        .IsRequired();
                    x.Property(m => m.Name)
                        .HasColumnName("payee_account_name")
                        .HasMaxLength(128)
                        .IsRequired();
                    x.Property(m => m.Number)
                        .HasColumnName("payee_account_no")
                        .HasMaxLength(128)
                        .IsRequired();
                });
            builder.Property(m => m.Amount)
                .HasColumnName("amount")
                .HasColumnType("money")
                .IsRequired();
            builder.Property(m => m.BizId)
                .HasColumnName("biz_id")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(m => m.IsAgent)
                .HasColumnName("is_agent")
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
        }
    }
}