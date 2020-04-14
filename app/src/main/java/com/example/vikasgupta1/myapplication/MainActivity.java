package com.example.vikasgupta1.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.SharedPreferences;
import android.content.pm.ActivityInfo;
import android.content.res.Configuration;
import android.os.Bundle;
import android.preference.PreferenceManager;
import android.util.Log;
import android.widget.VideoView;

import java.util.ArrayList;
import java.util.Arrays;
import android.media.MediaPlayer;
import android.net.Uri;

import android.os.Bundle;
import android.util.Log;
import android.widget.MediaController;
import android.widget.Toast;
import android.widget.VideoView;
import java.util.ArrayList;
import java.util.Arrays;

public class MainActivity extends AppCompatActivity {
    VideoView videoView;
    ArrayList<String> arrayList = new ArrayList<>(Arrays.asList("https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4",
            "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4"));
    int index = 0;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
      //  setRequestedOrientation(ActivityInfo.SCREEN_ORIENTATION_SENSOR_LANDSCAPE);

        //   int[] data = {3,6,2,7,5};
      //  System.out.println("days:"+ days(data));
        videoView = findViewById(R.id.videoView);
        final MediaController mediacontroller = new MediaController(this);
        mediacontroller.setAnchorView(videoView);


        videoView.setMediaController(mediacontroller);
        videoView.setVideoURI(Uri.parse(arrayList.get(index)));
        videoView.requestFocus();

        videoView.setOnPreparedListener(new MediaPlayer.OnPreparedListener() {
            @Override
            public void onPrepared(MediaPlayer mp) {
                mp.setOnVideoSizeChangedListener(new MediaPlayer.OnVideoSizeChangedListener() {
                    @Override
                    public void onVideoSizeChanged(MediaPlayer mp, int width, int height) {
                        videoView.setMediaController(mediacontroller);
                        mediacontroller.setAnchorView(videoView);

                    }
                });
            }
        });

        videoView.setOnCompletionListener(new MediaPlayer.OnCompletionListener() {
            @Override
            public void onCompletion(MediaPlayer mp) {
                Toast.makeText(getApplicationContext(), "Video over", Toast.LENGTH_SHORT).show();
                if (index++ == arrayList.size()) {
                    index = 0;
                    mp.release();
                    Toast.makeText(getApplicationContext(), "Videos completed", Toast.LENGTH_SHORT).show();
                } else {
                    videoView.setVideoURI(Uri.parse(arrayList.get(index)));
                    videoView.start();
                }


            }
        });

        videoView.setOnErrorListener(new MediaPlayer.OnErrorListener() {
            @Override
            public boolean onError(MediaPlayer mp, int what, int extra) {
                Log.d("API123", "What " + what + " extra " + extra);
                return false;
            }
        });
    }

    @Override
    public void onConfigurationChanged(Configuration newConfig)
    {
        Log.d("tag", "config changed");
        super.onConfigurationChanged(newConfig);

        int orientation = newConfig.orientation;
        if (orientation == Configuration.ORIENTATION_PORTRAIT)
            Log.d("tag", "Portrait");
        else if (orientation == Configuration.ORIENTATION_LANDSCAPE)
            Log.d("tag", "Landscape");
        else
            Log.w("tag", "other: " + orientation);

     }

    public int days(int[] data){
        boolean flag = true;
        int days =0;
        while(flag) {
            int a = data.length;
            data = destroyShip(data);
            if (a == data.length)
                flag = false;
            else
                days++;
        }
        return days;
    }
    public int[] destroyShip(int[] loot){
        int temp[] ={loot[0]};
        for(int i= 1;i<loot.length;i++){
            if(!(loot[i-1] <loot[i])){
                //i can use array package function also, then  no ned to write addElement function
                temp = addElement(temp,loot[i]);
            }
        }
       // Print days wise loots
        System.out.println( Arrays.toString(loot));

        return temp;
    }
    public int[] addElement(int[] old, int newelement) {
        int[] nEw = new int[old.length + 1];
        System.arraycopy(old, 0, nEw, 0, old.length);
        nEw[old.length] = newelement;
        return nEw ;
    }

}
