using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location
{

    //world coords
    private Vector3 worldCoord3D;
    private Vector2 worldCoord2D;

    //zone
    private ZoneTypes zone;
    public enum ZoneTypes
    {
        A,
        B,
        C,
        None
    }

    public Vector3 WorldCoord3D
    {
        get { return worldCoord3D; }
    }

    public Vector2 WorldCoord2D
    {
        get { return worldCoord2D; }
    }

    public ZoneTypes Zone
    {
        get { return zone; }
    }

    public Location(Vector3 worldCoord3D)
    {
        this.worldCoord3D = worldCoord3D;
        worldCoord2D = Vector2.zero;
        zone = ZoneTypes.None;
    }

    public Location(Vector2 worldCoord2D)
    {
        this.worldCoord2D = worldCoord2D;
        worldCoord3D = Vector3.zero;
        zone = ZoneTypes.None;
    }

    public Location(ZoneTypes zone)
    {
        worldCoord2D = Vector2.zero;
        worldCoord3D = Vector3.zero;
        this.zone = zone;
    }

    public bool Compare(Location location)
    {
        if (worldCoord3D != Vector3.zero && location.worldCoord3D == worldCoord3D)
        {
            return true;
        }
        else if (worldCoord2D != Vector2.zero && location.worldCoord2D == worldCoord2D)
        {
            return true;
        }
        else if (zone != ZoneTypes.None && location.zone == zone)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
