using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float lifePoints; //vida regen alterada com itens (função será necessária)
    private float manaPoints; //mana regen alterada com itens (função será necessária)
    private float atkPoints; //ataque utilizado por magias melee e ataques (dano físico)
    private float defPoints; //defesa para dano físico
    private float sabPoints; //pontuação de Sabedoria, usada para magias de longo alcance (dano mágico)
    private float malPoints; //pontuação de Malícia, usada para resistir a dano mágico

    public float getlifePoins()
    {
        return this.lifePoints;
    }

    public float getmanaPoins()
    {
        return this.manaPoints;
    }

    public float getatkPoins()
    {
        return this.atkPoints;
    }

    public float getdefPoins()
    {
        return this.defPoints;
    }

    public float getsabPoins()
    {
        return this.sabPoints;
    }

    public float getmalPoins()
    {
        return this.malPoints;
    }

    public void setlifePoins(float lifePoints)
    {
        this.lifePoints = lifePoints;
    }

    public void setmanaPoins(float manaPoints)
    {
        this.manaPoints = manaPoints;
    }

    public void setatkPoins(float atkPoints)
    {
        this.atkPoints = atkPoints;
    }

    public void setdefPoints(float defPoints)
    {
        this.defPoints = defPoints;
    }

    public void setsabPoints(float sabPoints)
    {
        this.sabPoints = sabPoints;
    }

    public void setmalPoints(float malPoints)
    {
        this.malPoints = malPoints;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
