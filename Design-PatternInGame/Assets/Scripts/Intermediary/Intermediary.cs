
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class BaseMediator{
    public abstract void Start();
    public abstract void Update();
    public abstract void End();
}
public class Intermediary : BaseMediator {
    public ConstructionSystem constructionSystem;
    public CountSystem countSystem;
    public MotionSystem motionSystem;
    public TimingSystem timingststem;
    public GameState gameState;
    public void Init () {
        constructionSystem = new ConstructionSystem (this);

        countSystem = new CountSystem (this);

        motionSystem = new MotionSystem (this);

        timingststem = new TimingSystem (this);
    }
    public override void End () {

        timingststem.OnEnd ();

        countSystem.OnEnd ();

        constructionSystem.OnEnd ();

        motionSystem.OnEnd ();

        this.gameState = GameState.GameEnd;
    }
    public override void Start () {
        constructionSystem.OnStart ();
        countSystem.OnStart ();
        motionSystem.OnStart ();
        timingststem.OnStart ();
        this.gameState = GameState.Gameing;
    }
    public override void Update () {

        timingststem.OnUpdate ();

        countSystem.OnUpdate ();

        constructionSystem.OnUpdate ();

        motionSystem.OnUpdate ();

    }
}