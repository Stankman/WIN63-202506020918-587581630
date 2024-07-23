using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Users;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Users;

public class ScrGetUserInfoMessageParser : AbstractParser<ScrGetUserInfoMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new ScrGetUserInfoMessage();
}