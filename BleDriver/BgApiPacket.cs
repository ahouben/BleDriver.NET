using System;

namespace BgApiDriver
{
    /// <summary>
    /// Base class for all types of packets going over the wire.
    /// </summary>
    public class BgApiPacket
    {
        public byte[] Data { get; set; }

        // header
        public int Length { get { return ((Data[0] & 0x7f) << 8) | Data[1]; } }
        public int Class { get { return Data[2]; } }
        public int Id { get { return Data[3]; } }
    }

    /// <summary>
    /// Base class for events and responses.
    /// </summary>
    public class BgApiEventResponse : BgApiPacket
    {
        public bool IsEvent { get { return (Data[0] & (byte)ble_msg_types.ble_msg_type_evt) == (byte)ble_msg_types.ble_msg_type_evt; } }

        public virtual int Result { get { return (int)ble_error.ble_err_success; } }
    }
    public class BgApiEvent : BgApiEventResponse { }
    public class BgApiResponse : BgApiEventResponse { }

    /// <summary>
    /// Base class for commands.
    /// </summary>
    public class BgApiCommand : BgApiPacket { }

}
