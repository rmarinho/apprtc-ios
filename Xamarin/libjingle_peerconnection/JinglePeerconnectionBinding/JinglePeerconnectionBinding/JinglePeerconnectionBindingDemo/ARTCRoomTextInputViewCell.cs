using Foundation;
using System;
using UIKit;

namespace JinglePeerconnectionBindingDemo
{
	public partial class ARTCRoomTextInputViewCell : UITableViewCell
	{
		public IRoomController RoomController;

		public ARTCRoomTextInputViewCell(IntPtr handle) : base(handle)
		{
		}

		partial void TouchButtonPressed(UIButton sender)
		{
			RoomController?.ShouldJoinRoom(this, textField.Text);
		}
	}
}