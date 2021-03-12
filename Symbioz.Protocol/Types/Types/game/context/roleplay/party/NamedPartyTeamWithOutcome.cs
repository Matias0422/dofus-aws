


















// Generated on 06/04/2015 18:45:30
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Types
{

public class NamedPartyTeamWithOutcome
{

public const short Id = 470;
public virtual short TypeId
{
    get { return Id; }
}

public Types.NamedPartyTeam team;
        public ushort outcome;
        

public NamedPartyTeamWithOutcome()
{
}

public NamedPartyTeamWithOutcome(Types.NamedPartyTeam team, ushort outcome)
        {
            this.team = team;
            this.outcome = outcome;
        }
        

public virtual void Serialize(ICustomDataOutput writer)
{

team.Serialize(writer);
            writer.WriteVarUhShort(outcome);
            

}

public virtual void Deserialize(ICustomDataInput reader)
{

team = new Types.NamedPartyTeam();
            team.Deserialize(reader);
            outcome = reader.ReadVarUhShort();
            if (outcome < 0)
                throw new Exception("Forbidden value on outcome = " + outcome + ", it doesn't respect the following condition : outcome < 0");
            

}


}


}