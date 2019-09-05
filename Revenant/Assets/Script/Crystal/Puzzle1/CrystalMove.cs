﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalMove : CrystalPuzzle
{
    public Vector3[] pos;
    public Vector3 target;
    private void Start()
    {
        c_state = GetComponent<EmptyCrystal>();
        c_state.state = C_STATE.EMPTY;
        pos = new Vector3[5];
        for(int i = 0; i <5; i++)
        {
            pos[i] = transform.position;
        }
        pos[0].x += 5;
        pos[1].x -= 5;
        pos[2].z += 5;
        pos[3].z -= 5;
        target = pos[4];
    }
    private void Update()
    {
        if (c_state.isActive)
        {
            if (transform.position == pos[4] && c_state.state != C_STATE.EMPTY)
            {
                TargetPosChange();
            }
            else if (transform.position != pos[4]  && c_state.state == C_STATE.EMPTY)
            {
                target = pos[4];
            }
            //중앙이 아닐때는 중앙으로 /중앙 포지션과는 비슷해지면 초기화
            if (((target.z - transform.position.z) < 0.1f && (target.z - transform.position.z) > -0.1f)
                && ((target.x - transform.position.x) < 0.1f && (target.x - transform.position.x) > -0.1f))
            {
                transform.position = target;
            }
            TargetArrive(target);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (c_state.isActive)
            transform.position = Vector3.Lerp(transform.position, target, Time.fixedDeltaTime * 2f);
    }

    void TargetPosChange()
    {
        switch (c_state.state)
        {
            case C_STATE.EMPTY:
                break;
            case C_STATE.BLUE:
                target = pos[0]; //empty
                break;
            case C_STATE.WHITE:
                target = pos[1]; //empty
                break;
            case C_STATE.RED:
                target = pos[2]; //empty
                break;
            case C_STATE.BLACK:
                target = pos[3]; //empty
                break;
        }
    }

    void TargetArrive(Vector3 aPos)
    {
        if ((target == transform.position && c_state.state != C_STATE.EMPTY && target != pos[4]) ||
            (transform.position == pos[4] && c_state.state == C_STATE.EMPTY))
        {
            c_state.isActive = false; target = pos[4];
        }
    }
}