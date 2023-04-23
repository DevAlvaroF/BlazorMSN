using BlazorMSN.UI.Data;
using Microsoft.AspNetCore.SignalR;

namespace BlazorMSN.UI.Hubs
{
	public class ChatHub : Hub
	{

		private readonly ILogger<ChatHub> _logger;
		public ChatHub(ILogger<ChatHub> logger)
		{
			_logger = logger;
		}

		// To send message we ask the connection to receive
		public async Task SendMessage(Guid userId, string message, string userName, string imageId)
		{
			await Clients.All.SendAsync(ChatClientDefaultParams.RECEIVE, userId, message, userName, imageId);
		}

		//public override Task OnConnectedAsync()
		//{
		//	_logger.LogInformation("Connected");
		//	return base.OnConnectedAsync();
		//}

		//public override async Task OnDisconnectedAsync(Exception? exception)
		//{
		//	_logger.LogInformation($"Disconnected {exception?.Message} ~ {Context.ConnectionId}");

		//	string connectionId = Context.ConnectionId;

		//	bool wasDeleted = await _userDeleterService.DeleteUser(connectionId);


		//	await Clients.AllExcept(connectionId).SendAsync(ChatClientDefaultParams.RECEIVE, "caca", "has left the chat");
		//	await base.OnDisconnectedAsync(exception);
		//}
	}
}
