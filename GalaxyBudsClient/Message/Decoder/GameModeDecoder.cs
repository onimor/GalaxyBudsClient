using GalaxyBudsClient.Generated.Model.Attributes;

namespace GalaxyBudsClient.Message.Decoder;

[MessageDecoder(MsgIds.GAME_MODE)]
internal class GameModeDecoder : BaseMessageDecoder
{
    public bool Enabled { get; }

    public GameModeDecoder(SppMessage msg) : base(msg)
    {
        Enabled = msg.Payload.Length > 0 && msg.Payload[0] == 0x01;
    }
}
