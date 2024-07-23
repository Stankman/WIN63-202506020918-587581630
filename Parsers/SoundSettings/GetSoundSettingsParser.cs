using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.SoundSettings;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.SoundSettings;

public class GetSoundSettingsParser : AbstractParser<GetSoundSettingsMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetSoundSettingsMessage();
}