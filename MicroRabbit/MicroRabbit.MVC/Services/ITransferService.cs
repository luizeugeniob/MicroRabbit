using MicroRabbit.MVC.Models.Dto;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferDto transferDto);
    }
}
