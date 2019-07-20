using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float lifePoints; //vida regen alterada com itens (função será necessária)
    private float current_lifePoints;
    private float manaPoints; //mana regen alterada com itens (função será necessária)
    private float current_manaPoints;
    private float atkPoints; //ataque utilizado por magias melee e ataques (dano físico)
    private float defPoints; //defesa para dano físico
    private float sabPoints; //pontuação de Sabedoria, usada para magias de longo alcance (dano mágico)
    private float malPoints; //pontuação de Malícia, usada para resistir a dano mágico

    public float getlifePoints()
    {
        return this.lifePoints;
    }

    public float getcurrent_lifePoints()
    {
        return this.current_lifePoints;
    }

    public float getcurrent_ManaPoints()
    {
        return this.current_manaPoints;
    }

    public float getmanaPoints()
    {
        return this.manaPoints;
    }

    public float getatkPoints()
    {
        return this.atkPoints;
    }

    public float getdefPoints()
    {
        return this.defPoints;
    }

    public float getsabPoints()
    {
        return this.sabPoints;
    }

    public float getmalPoints()
    {
        return this.malPoints;
    }

    public void setlifePoints(float lifePoints)
    {
        this.lifePoints = lifePoints;
    }

    public void setmanaPoints(float manaPoints)
    {
        this.manaPoints = manaPoints;
    }

    public void setatkPoints(float atkPoints)
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
