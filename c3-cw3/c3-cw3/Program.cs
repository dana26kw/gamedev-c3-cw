using System;

namespace c3_cw3
{
    class Program
    {
        static void Main(string[] args) {
            void OnMousedrag() {
                Vector2 mousepos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                Vector2 playerpos = Camera.main.screenToWorldPoint(mousepos);
                transform.position = playerPos; }

            void OnCollisionEnter2D(Collision2D other)
            {
                SceneManager.LoadScene("Lvl1");
            }

            void OnTriggerEnter2D(Collider2D other) {

                SceneManager.LoadScene("Lvl2");
            }
            void start()
            {

            }

            void update()
            {

            }

        }
    }
}

