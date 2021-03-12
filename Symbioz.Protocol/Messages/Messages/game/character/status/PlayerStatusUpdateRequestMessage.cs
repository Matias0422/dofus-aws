


















// Generated on 06/04/2015 18:44:16
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class PlayerStatusUpdateRequestMessage : Message
{

public const ushort Id = 6387;
public override ushort MessageId
{
    get { return Id; }
}

public Types.PlayerStatus status;
        

public PlayerStatusUpdateRequestMessage()
{
}

public PlayerStatusUpdateRequestMessage(Types.PlayerStatus status)
        {
            this.status = status;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteShort(status.TypeId);
            status.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

status = Types.ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadShort());
            status.Deserialize(reader);
            

}


}


}