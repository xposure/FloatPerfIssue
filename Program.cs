using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace FloatPerfDegrades
{
    public struct Velocity
    {
        public float x;
        public float y;
        public Velocity(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }

    [SimpleJob(launchCount: 1, warmupCount: 3, targetCount: 5, invocationCount: 2000, id: "QuickJob")]
    //[MediumRunJob]
    public class FloatBenchmark
    {
        public float dt = 0.016f;
        public Velocity[] _velocities;
        public int N = 100000;

        [GlobalSetup]
        public void Setup()
        {
            _velocities = new Velocity[N];

            var r = new Random();
            for (var i = 0; i < N; i++)
                _velocities[i] = new Velocity(r.Next(-500, 500), r.Next(-500, 500));
        }

        [Benchmark]
        public void HelpMe()
        {
            for (var i = 0; i < N; i++)
            {
                ref var velocity = ref _velocities[i];
                velocity.x -= velocity.x * dt;
                velocity.y += velocity.y * dt;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<FloatBenchmark>();
        }
    }
}
