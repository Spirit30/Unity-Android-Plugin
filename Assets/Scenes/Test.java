package com.company.example;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.content.Context;

public class Test {

    static Activity _activity;

    public static void CallAndroid(Activity activity)
    {
        _activity = activity;
        Log.d("#####", "CallAndroid() - Telemetry is fine.");

        //Continue doing what you need...
    }
}